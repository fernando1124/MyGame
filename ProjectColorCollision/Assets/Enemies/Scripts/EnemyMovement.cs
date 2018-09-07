using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    private Vector3 movingSpeed;
    private Transform objectTransform;

    // Use this for initialization
    void Start () {
        movingSpeed = Vector3.left * Time.deltaTime;
        objectTransform = this.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        objectTransform.Translate(movingSpeed);
    }
}
