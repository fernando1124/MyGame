using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game.player
{
    public class PlayerMovementController : MonoBehaviour
    {
        private float speed;

        void Update()
        {
            movementListener();
        }

        private void movementListener()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

        public void setSpeed(float speed)
        {
            this.speed = speed;
        }

        public bool isMovingInX()
        {
            return Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow);

        }

        public bool isMovingInY()
        {
            return Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow);

        }

        public bool isMovingLeft()
        {
            return Input.GetKey(KeyCode.LeftArrow);
        }

        public bool isMovingUp()
        {
            return Input.GetKey(KeyCode.UpArrow);
        }
    }
}