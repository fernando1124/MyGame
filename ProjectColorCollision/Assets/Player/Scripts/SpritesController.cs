using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game.player
{
    public class SpritesController : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        private PlayerMovementController movementController;

        void Awake()
        {
            spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            movementController = this.gameObject.GetComponent<PlayerMovementController>();
        }


        // Update is called once per frame
        void Update()
        {
            spriteDirectionToMovement();
        }

        private void spriteDirectionToMovement()
        {
            spriteRenderer.flipX = (movementController.isMovingInX() & movementController.isMovingLeft());
            spriteRenderer.flipY = (movementController.isMovingInY() & movementController.isMovingUp());
        }
    }
}
