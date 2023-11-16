using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private CubeHolder cubeRef;
    [SerializeField] private List<Transform> spawnPoints;

    private List<GameObject> cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = cubeRef.cubesList;
        SpawnCubes();

    }

    void SpawnCubes()
    {
        for (int i = 0; i < cubes.Count; i++)
        {
            Instantiate(cubes[i], spawnPoints[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
