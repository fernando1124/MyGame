using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using game.player;

public class PlayerController : MonoBehaviour, FinishableComponent {

    private int hitsCounter;
    public float speed;

    private PlayerMovementController playerMovementController;
    private AnimationController animationController;
    private SpritesController spritesController;

    void Awake()
    {
        hitsCounter = 0;
        playerMovementController = this.gameObject.AddComponent<PlayerMovementController>();
        animationController = this.gameObject.AddComponent<AnimationController>();
        spritesController = this.gameObject.AddComponent<SpritesController>();

        configComponents();
        GameController.getInstance().suscribeToGame(this);
    }

	void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("COLLISION!!");
        Color enemyColor = collision.gameObject.GetComponentInChildren<SpriteRenderer>().color;
        Color blend = ColorUtil.getInstance().calculateBlend(spritesController.getColor(), enemyColor);

        spritesController.updateColor(blend);
        hitsCounter++;

        if(hitsCounter >= 3) {
            GameController.getInstance().finishGame();
        }
    }

    private void configComponents()
    {
        playerMovementController.setSpeed(speed);
    }

    public bool finish() {
        playerMovementController.enabled = false;
        animationController.enabled = false;
        spritesController.enabled = false;

        return true;
    }
}
