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

	// Update is called once per frame
	void Update () {
		
	}

    private void configComponents()
    {
        playerMovementController.setSpeed(speed);
    }
}
