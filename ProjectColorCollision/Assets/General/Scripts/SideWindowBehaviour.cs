using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWindowBehaviour : MonoBehaviour {
    private float backgroundSize;
    private Transform transform;

    private Vector3 speed;

	// Use this for initialization
	void Awake () {
        this.transform = this.GetComponent<Transform>();
        backgroundSize = transform.localScale.x;
        speed = Vector3.left * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < -backgroundSize) {
            repositionBackground();
        }
        transform.Translate(speed);
	}

    private void repositionBackground() {
        Vector3 groundOffset = new Vector3(backgroundSize * 2f, 0, 0);

        transform.position = transform.position + groundOffset;
    }
}
