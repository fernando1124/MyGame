using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private const string OBJECT_COLLECTOR = "DestroyEdge";    

	void Start () {
        this.GetComponent<Transform>().localEulerAngles = new Vector3(0, 0, Random.Range(1, 50));
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag.Equals(OBJECT_COLLECTOR)) {
            GameObject.Destroy(this.gameObject);
        }
    }
}
