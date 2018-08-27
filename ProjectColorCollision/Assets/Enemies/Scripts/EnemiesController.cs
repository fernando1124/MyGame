using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour {
    private const string PLAYER_OBJECT_NAME = "Player";

    private GameObject player;
    private Vector3 direction;

    void Awake()
    {
        player = GameObject.Find(PLAYER_OBJECT_NAME);
    }

	// Use this for initialization
	void Start () {
        direction = (player.transform.position - this.gameObject.transform.position).normalized;
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * 4f, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}