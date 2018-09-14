using UnityEngine;

public class EnemyData {
    private const string BASIC_ENEMY_PREFAB = "Enemies/Prefab/Stroke2";

    public const EnemyData EMPTY_ENEMY = null;

    private string prefab;
    private Color color;
    private Vector3 rotation;
    private bool flipY;

    public float lowerBound;
    public float higherBound;


    public EnemyData(float lowerBound, float higherBound) : this(BASIC_ENEMY_PREFAB, lowerBound, higherBound, Color.red, Vector3.down, false) { }
    public EnemyData(Color color, Vector3 rotation, bool flipY) : this(BASIC_ENEMY_PREFAB, 0, 0, color, rotation, flipY) { }
    public EnemyData(string prefab, Color color, Vector3 rotation, bool flipY) : this(prefab, 0, 0, color, rotation, flipY) { }

    public EnemyData(string prefab, float lowerBound, float higherBound, Color color, Vector3 rotation, bool flipY) {
        this.prefab = prefab;
        this.lowerBound = lowerBound;
        this.higherBound = higherBound;
        this.color = color;
        this.rotation = rotation;
        this.flipY = flipY;
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

    public bool isFlipY() {
        return this.flipY;
    }
}
