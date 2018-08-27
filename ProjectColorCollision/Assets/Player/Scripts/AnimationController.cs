using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game.player;

public class AnimationController : MonoBehaviour {
    private const string MOVINGX_PARAM = "MovingX";
    private const string MOVINGY_PARAM = "MovingY";

    private Animator animator;
    private PlayerMovementController movementController;

    void Awake()
    {
        animator = this.gameObject.GetComponent<Animator>();
        movementController = this.gameObject.GetComponent<PlayerMovementController>();
    }
	
	void Update () {
        updateAnimatorFlags();
	}

    private void updateAnimatorFlags()
    {
        animator.SetBool(MOVINGX_PARAM, movementController.isMovingInX());
        animator.SetBool(MOVINGY_PARAM, movementController.isMovingInY());
    }
}
