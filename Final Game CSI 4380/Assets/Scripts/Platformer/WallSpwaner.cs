using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpwaner : MonoBehaviour
{
    [SerializeField]
    SpawningManager TallWall;
    [SerializeField]
    SpawningManager MediumWall;
    [SerializeField]
    SpawningManager ShortWall;
    void Start()
    {
        StartSpawning();
    }

    private void StartSpawning()
    {
        StartCoroutine(SpawnWalls());
    }

    IEnumerator SpawnWalls()
    {
        yield return new WaitForSeconds(3);
        GameObject wall;
        switch (UnityEngine.Random.Range(0,2))
        {
            case 0:
                wall = Instantiate(TallWall.wall);
                wall.transform.localScale = new Vector2(TallWall.wallThickness, TallWall.wallHeight);
                break;
            case 1:
                wall = Instantiate(MediumWall.wall);
                wall.transform.localScale = new Vector2(MediumWall.wallThickness, MediumWall.wallHeight);
                break;
            case 2:
                wall = Instantiate(ShortWall.wall);
                wall.transform.localScale = new Vector2(ShortWall.wallThickness, ShortWall.wallHeight);
                break;
            default:
                break;
        }
        StartCoroutine(SpawnWalls());
    }


}
