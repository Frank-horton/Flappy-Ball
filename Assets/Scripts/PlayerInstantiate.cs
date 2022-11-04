using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstantiate : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject PlayerINst;
    public float Time;

    [SerializeField] private GameObject GameOverPanel;

    void Start()
    {      
        StartCoroutine(SpawnPlayer()); 
        GameOverPanel.SetActive(false);
    }

    IEnumerator SpawnPlayer()
    {
        yield return new WaitForSeconds(Time);
        Instantiate(PlayerINst, SpawnPos.position, Quaternion.identity);      
    }
}