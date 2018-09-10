using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory {

	public static EnemyData createBasicEnemy() {
        return new EnemyData(generateColor(), new Vector3(0, 0, Random.Range(0, 360)));
    }

    private static Color generateColor() {
        return Random.ColorHSV(0, 1, 0, 1, 0.5f, 1);
    }
}
