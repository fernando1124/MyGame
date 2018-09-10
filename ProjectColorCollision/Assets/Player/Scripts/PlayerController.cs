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
    private BlinkRoutine blinkRoutine;

    void Awake()
    {
        hitsCounter = 0;
        playerMovementController = this.gameObject.AddComponent<PlayerMovementController>();
        animationController = this.gameObject.AddComponent<AnimationController>();
        spritesController = this.gameObject.AddComponent<SpritesController>();
        blinkRoutine = new BlinkRoutine(this);

        configComponents();
        GameController.getInstance().suscribeToGame(this);
    }

	void OnCollisionEnter2D(Collision2D collision) {
        blendColor(collision.gameObject.GetComponentInChildren<SpriteRenderer>().color);
        startFlickering();
        hitsCounter++;

        if(hitsCounter >= 3) {
            GameController.getInstance().finishGame();
        }
    }

    private void configComponents() {
        playerMovementController.setSpeed(speed);
    }

    private void blendColor(Color enemyColor) {
        Color blend = ColorUtil.getInstance().calculateBlend(spritesController.getColor(), enemyColor);
        spritesController.updateColor(blend);
    }

    private void startFlickering() {
        this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        blinkRoutine.start(5, 0.2f);
    }

    public bool finish() {
        playerMovementController.enabled = false;
        animationController.enabled = false;
        spritesController.enabled = false;

        return true;
    }
}
