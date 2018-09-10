using UnityEngine;

public class EnemyData {
    private const string BASIC_ENEMY_PREFAB = "Enemies/Prefab/Enemy";
    public const EnemyData EMPTY_ENEMY = null;

    private string prefab;
    private Color color;
    private Vector3 rotation;

    public float lowerBound;
    public float higherBound;


    public EnemyData(float lowerBound, float higherBound) : this(BASIC_ENEMY_PREFAB, lowerBound, higherBound, Color.red, Vector3.down) { }
    public EnemyData(Color color, Vector3 rotation) : this(BASIC_ENEMY_PREFAB, 0, 0, color, rotation) { }

    public EnemyData(string prefab, float lowerBound, float higherBound, Color color, Vector3 rotation) {
        this.prefab = prefab;
        this.lowerBound = lowerBound;
        this.higherBound = higherBound;
        this.color = color;
        this.rotation = rotation;
    }

    public string getPrefab() {
        return this.prefab;
    }

    public Color getColor() {
        return this.color;
    }

    public Vector3 getRotation() {
        return this.rotation;
    }
}
