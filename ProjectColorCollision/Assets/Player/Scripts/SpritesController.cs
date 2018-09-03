using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game.player
{
    public class SpritesController : MonoBehaviour, FinishableComponent
    {
        private SpriteRenderer spriteRenderer;
        private PlayerMovementController movementController;

        void Awake()
        {
            spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            movementController = this.gameObject.GetComponent<PlayerMovementController>();

            GameController.getInstance().suscribeToGame(this);
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

        public void updateColor(Color color) {
            spriteRenderer.color = color;
        }

        public Color getColor() {
            return this.spriteRenderer.color;
        }

        public bool finish() {
            this.enabled = false;
            return true;
        }
    }
}
