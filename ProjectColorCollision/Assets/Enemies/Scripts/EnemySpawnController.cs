using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour, FinishableComponent {
    private const string FN_RESTORE_SPAWN = "restoreSpawn";

    private Transform parentTransform;
    private Transform[] spawnPoints;
    private AudioSource audioController;
    private AudioProcessor audioProcessor;
    private bool spawned;

	// Use this for initialization
	void Awake () {
        spawnPoints = this.GetComponentsInChildren<Transform>();
        audioController = this.GetComponent<AudioSource>();
        audioProcessor = this.GetComponent<AudioProcessor>();
        parentTransform = this.GetComponent<Transform>();

        GameController.getInstance().suscribeToGame(this);
    }

    void Start() {
        audioController.Play();
        audioProcessor.onSpectrum.AddListener(spawnOnSnareDrum);
        InvokeRepeating(FN_RESTORE_SPAWN, 1f, 1f);
    }

    void restoreSpawn() { spawned = false; }

    void spawnOnFloorDrum(float[] spectrum) {
        if (!spawned) {
            int point = Random.Range(1, spawnPoints.Length);

            EnemyData enemy = EnemyFactory.createBasicEnemy();
            //if (spectrum[2] >= 0.01f & spectrum[2] <= 0.02f) {
            Instantiate(Resources.Load<GameObject>(enemy.getPrefab()), spawnPoints[point].position, spawnPoints[point].rotation);
                //instance.GetComponentInChildren<TextMesh>().text = "11 - " + spectrum[11];
                spawned = true;
            //}
        }
    }

    void spawnOnSnareDrum(float[] spectrum)
    {
        if(!spawned) {
            int point = Random.Range(1, spawnPoints.Length);

            for (int i = 0; i < 1; i++) {                
                if (spectrum[i] >= 0.01f & spectrum[i] <= 0.02f) {
                    spawnEnemyAt(EnemyFactory.createBasicEnemy(), spawnPoints[point].position);
                    spawned = true;
                }
            }
        }
        

        //Debug.Log("SPECTRUM 1 " + spectrum[0] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 2 " + spectrum[1] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 3 " + spectrum[2] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 4 " + spectrum[3] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 5 " + spectrum[4] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 6 " + spectrum[5] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 7 " + spectrum[6] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 8 " + spectrum[7] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 9 " + spectrum[8] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 10 " + spectrum[9] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 11 " + spectrum[10] + "TIME: " + audioController.time);
        //Debug.Log("SPECTRUM 12 " + spectrum[11] + "TIME: " + audioController.time);
        //int point = Random.Range(1, spawnPoints.Length);
        //Instantiate(Resources.Load<GameObject>("Enemies/Prefab/UpRightEnemy"), spawnPoints[point].position, spawnPoints[point].rotation);
        //for(int i=0; i<data.getQuantity(); i++) {
        //    int spawnPoint = Random.Range(1, spawnPoints.Length);
        //    Instantiate(Resources.Load<GameObject>(data.getPrefab()),
        //    spawnPoints[spawnPoint].position,
        //    spawnPoints[spawnPoint].rotation);
        //}
    }

    private void spawnEnemyAt(EnemyData enemy, Vector3 position) {
        GameObject enemyObject = Resources.Load<GameObject>(enemy.getPrefab());
        enemyObject.GetComponentsInChildren<Transform>()[1].eulerAngles = enemy.getRotation();
        enemyObject.GetComponentInChildren<SpriteRenderer>().color = enemy.getColor();
        enemyObject.GetComponentInChildren<SpriteRenderer>().flipY = enemy.isFlipY();

        Instantiate(enemyObject, position, Quaternion.identity, parentTransform);
        //GameObject instance = Instantiate(Resources.Load<GameObject>(enemy.getPrefab()), position, Quaternion.identity);
        //instance.GetComponentsInChildren<Transform>()[1].eulerAngles = enemy.getRotation();
        //instance.GetComponentInChildren<SpriteRenderer>().color = enemy.getColor();
        //instance.GetComponentInChildren<SpriteRenderer>().material.color = enemy.getColor();
        //instance.GetComponentInChildren<SpriteRenderer>().flipY = enemy.isFlipY();
    }

    public bool finish() {
        audioController.enabled = false;
        audioProcessor.enabled = false;
        CancelInvoke(FN_RESTORE_SPAWN);
        return true;
    }
}