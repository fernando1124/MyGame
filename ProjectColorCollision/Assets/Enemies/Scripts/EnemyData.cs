using UnityEngine;

public class EnemyData {
    //private const string BASIC_ENEMY_PREFAB = "Enemies/Prefab/UpRightEnemy";
    private const string BASIC_ENEMY_PREFAB = "Enemies/Prefab/FrontEnemy";
    public const EnemyData EMPTY_ENEMY = null;

    private string prefab;
    private int quantity;
    private Color color;

    public float lowerBound;
    public float higherBound;


    public EnemyData(float lowerBound, float higherBound) : this(BASIC_ENEMY_PREFAB, 1, lowerBound, higherBound, Color.red) { }
    public EnemyData(int quantity, float lowerBound, float higherBound) : this(BASIC_ENEMY_PREFAB, quantity, lowerBound, higherBound, Color.red) { }

    public EnemyData(string prefab, int quantity, float lowerBound, float higherBound, Color color) {
        this.prefab = prefab;
        this.quantity = quantity;
        this.lowerBound = lowerBound;
        this.higherBound = higherBound;
        this.color = color;
    }

    public string getPrefab() {
        return this.prefab;
    }

    public int getQuantity() {
        return this.quantity;
    }

    public Color getColor() {
        return this.color;
    }
}
