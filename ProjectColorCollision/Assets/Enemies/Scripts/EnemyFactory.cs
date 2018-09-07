using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory {

    private const string BASIC_ENEMY_PREFAB = "Enemies/Prefab/Enemy";
    private static Color[] colors = new Color[]{ Color.red, Color.green, Color.blue };

	public static EnemyData createBasicEnemy() {
        return new EnemyData(BASIC_ENEMY_PREFAB, 1, 0f, 0f, colors[Random.Range(0, 3)]);
    }



}
