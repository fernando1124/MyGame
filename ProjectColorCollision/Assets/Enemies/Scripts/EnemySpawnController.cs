using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

    public GameObject enemy;
    public Transform[] spawnPoints;

    private AudioSource audioController;

	// Use this for initialization
	void Awake () {
        audioController = this.gameObject.GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
        if (audioController.time >= 2.5f & audioController.time <= 2.6f)
        {
            spawn(0);
        }
        if (audioController.time >= 4.0f & audioController.time <= 4.1f)
        {
            spawn(1);
        }
        if (audioController.time >= 4.6f & audioController.time <= 4.7f)
        {
            spawn(2);
        }
        if (audioController.time >= 6.2f & audioController.time <= 6.3f)
        {
            spawn(1);
        }

        if (audioController.time >= 7.2f & audioController.time <= 7.3f)
        {
            spawn(0);
        }
        if (audioController.time >= 8.8f & audioController.time <= 8.8f)
        {
            spawn(0);
        }
    }

    void spawn(int spawnPoint)
    {
        Instantiate(enemy, spawnPoints[spawnPoint].position, spawnPoints[spawnPoint].rotation);
    }
}
