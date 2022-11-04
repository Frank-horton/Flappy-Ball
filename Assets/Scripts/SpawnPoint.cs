using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] obs;
    public float spawnDelay = 1;

    void Start()
    {
        InvokeRepeating("Spawn",0, spawnDelay);
    }

    void Spawn()
    {
        Instantiate(obs[Random.Range(0,3)], transform.position, Quaternion.identity);
    }
}