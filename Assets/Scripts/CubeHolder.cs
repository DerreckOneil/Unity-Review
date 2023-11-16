using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CubeHolder : ScriptableObject
{
    [SerializeField] private List<GameObject> cubes;
    [SerializeField] private List<Transform> spawnPoints;

    public List<GameObject> cubesList => cubes;
    public List<Transform> spawnPointsList => spawnPoints;
    
}
