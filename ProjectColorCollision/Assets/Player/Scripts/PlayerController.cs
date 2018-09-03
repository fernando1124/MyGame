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
        Color enemyColor = collision.gameObject.GetComponentInChildren<SpriteRenderer>().color;
        Color blend = ColorUtil.getInstance().calculateBlend(spritesController.getColor(), enemyColor);

        spritesController.updateColor(blend);
    }

    private void configComponents()
    {
        playerMovementController.setSpeed(speed);
    }
}
