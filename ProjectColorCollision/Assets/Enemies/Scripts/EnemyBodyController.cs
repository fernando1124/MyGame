using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodyController : MonoBehaviour {
    private const string OBJECT_COLLECTOR = "DestroyEdge";

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag.Equals(OBJECT_COLLECTOR)) {
            GameObject.Destroy(this.gameObject.transform.parent.gameObject);
        }
    }
}
