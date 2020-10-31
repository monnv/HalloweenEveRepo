using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerSingle : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    public float min;
    public float max;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(min, max);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
