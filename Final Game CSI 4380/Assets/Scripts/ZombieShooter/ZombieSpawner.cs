using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    [SerializeField] Enemy enemy;
    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }

}
