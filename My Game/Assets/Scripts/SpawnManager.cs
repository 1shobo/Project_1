using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 150;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float startDelayA = 1;
    private float spawnInterval = 1.5f;
    private PlayerController playerControllerScript;
    private GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAlien", startDelayA, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnRandomObstacle() {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs[obstacleIndex], new Vector3(-spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ)),
           obstaclePrefabs[obstacleIndex].transform.rotation);

            //gameManagerScript.UpdateScore(5);
        }
       

    }

    void SpawnRandomAlien()
    {
        int alienIndex = Random.Range(0, alienPrefabs.Length);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(alienPrefabs[alienIndex], new Vector3(-spawnRangeX, 4, Random.Range(-spawnRangeZ, spawnRangeZ)),
            alienPrefabs[alienIndex].transform.rotation);
        }

    }
}
