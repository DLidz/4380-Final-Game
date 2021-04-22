using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Wall Prefab", menuName = "ScriptableObjects/SpawnManager", order = 1)]
public class SpawningManager : ScriptableObject
{
    public GameObject wall;
    public string prefabName;
    public float wallHeight;
    public float wallThickness;
}
