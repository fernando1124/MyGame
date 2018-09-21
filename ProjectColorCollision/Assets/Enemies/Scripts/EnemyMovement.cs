using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour, FinishableComponent {
    private Vector3 movingSpeed;
    private Transform objectTransform;

    // Use this for initialization
    void Start () {
        movingSpeed = Vector3.left * Time.deltaTime;
        objectTransform = this.GetComponent<Transform>();
        GameController.getInstance().suscribeToGame(this);
    }
	
	// Update is called once per frame
	void Update () {
        objectTransform.Translate(movingSpeed);
    }

    public bool finish() {
        this.GetComponentInChildren<Collider2D>().enabled = false;
        this.enabled = false;
        return true;
    }
}
