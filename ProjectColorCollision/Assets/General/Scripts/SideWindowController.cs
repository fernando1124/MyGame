using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWindowController : MonoBehaviour, FinishableComponent {
    private float backgroundSize;
    private Transform backgrounTransform;

    private Vector3 speed;

	// Use this for initialization
	void Awake () {
        this.backgrounTransform = this.GetComponent<Transform>();
        backgroundSize = backgrounTransform.localScale.x;
        speed = Vector3.left * Time.deltaTime;

        GameController.getInstance().suscribeToGame(this);
	}
	
	// Update is called once per frame
	void Update () {
        if(backgrounTransform.position.x < -backgroundSize) {
            repositionBackground();
        }
        backgrounTransform.Translate(speed);
	}

    private void repositionBackground() {
        Vector3 groundOffset = new Vector3(backgroundSize * 2f, 0, 0);

        backgrounTransform.position = backgrounTransform.position + groundOffset;
    }

    public bool finish() {
        this.enabled = false;
        return true;
    }
}
