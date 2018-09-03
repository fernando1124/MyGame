using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour {
    private const string PLAYER_OBJECT_NAME = "Player";
    private const string SCREEN_EDGE_DESTROY = "DestroyEdge";
    private const string PLAYER_TAG = "Player";

    private GameObject player;
    private Vector3 direction;

    void Awake() {
        player = GameObject.Find(PLAYER_OBJECT_NAME);
    }

	// Use this for initialization
	void Start () {
        direction = (player.transform.position - this.gameObject.transform.position).normalized;
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * 4f, ForceMode2D.Impulse);
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag.Equals(player.tag)) {
            GameObject.Destroy(this.gameObject);
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag.Equals(SCREEN_EDGE_DESTROY)) {
            GameObject.Destroy(this.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}