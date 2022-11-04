using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int numb;

    public void Start()
    {
        numb = DataHolder.ChoisePlayer;
        PlayerChoise();       
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void PlayerChoise()
    {
        if (numb == 0) speed = 10;
        if (numb == 1) speed = 15;
        if (numb == 2) speed = 20;
    }
}