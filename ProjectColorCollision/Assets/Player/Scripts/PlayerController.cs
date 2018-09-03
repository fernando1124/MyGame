using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game.player;

public class PlayerController : MonoBehaviour {

    public float speed;

    private PlayerMovementController playerMovementController;
    private AnimationController animationController;
    private SpritesController spritesController;

    void Awake()
    {
        playerMovementController = this.gameObject.AddComponent<PlayerMovementController>();
        animationController = this.gameObject.AddComponent<AnimationController>();
        spritesController = this.gameObject.AddComponent<SpritesController>();

        configComponents();
    }

	void OnCollisionEnter2D(Collision2D collision) {
        Color color = collision.gameObject.GetComponentInChildren<SpriteRenderer>().color;

        spritesController.updateColor(calculateColor(color));
    }

    private Color calculateColor(Color attackingColor) {
        Color playerColor = spritesController.getColor();

        attackingColor = attackingColorComplement(attackingColor);

        playerColor = playerColor - attackingColor;
        //if (attackingColor == Color.red) {
        //    playerColor.b = playerColor.b - 0.3f;
        //    playerColor.g = playerColor.g - 0.3f;
        //}

        //if (attackingColor == Color.blue) {
        //    playerColor.r = playerColor.r - 0.3f;
        //    playerColor.g = playerColor.g - 0.3f;
        //}

        //if (attackingColor == Color.green) {
        //    playerColor.b = playerColor.b - 0.3f;
        //    playerColor.r = playerColor.r - 0.3f;
        //}

        return playerColor;
    }

    private Color attackingColorComplement(Color attackingColor) {
        float red = 1 - attackingColor.r;
        float green = 1 - attackingColor.g;
        float blue = 1 - attackingColor.b;
        
        return new Color(red * 0.3f, green * 0.3f, blue * 0.3f, 0);
    }

    private void configComponents()
    {
        playerMovementController.setSpeed(speed);
    }
}
