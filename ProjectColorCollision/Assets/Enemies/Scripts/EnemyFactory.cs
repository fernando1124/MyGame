using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory {
    private static string[] ENEMY_PREFABS = new string[] { "Enemies/Prefab/Stroke2"};

    public static EnemyData createBasicEnemy() {
        return new EnemyData(generateRandomPrefab(), generateColor(), generateRandomRotation(), generateRandomFlipY());
    }

    private static Color generateColor() {
        return Random.ColorHSV(0, 1, 0, 1, 0.5f, 1);
    }

    private static bool generateRandomFlipY() {
        return Random.Range(0, 1) > 0.5f;
    }

    private static Vector3 generateRandomRotation() {
        return new Vector3(0, 0, Random.Range(0, 360));
    }

    private static string generateRandomPrefab() {
        return ENEMY_PREFABS[Random.Range(0, ENEMY_PREFABS.Length)];

    }
}
