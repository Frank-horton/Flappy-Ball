using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpPower = 5;

    public static int EndGamePanel = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity += Vector3.up * jumpPower;
        }     
    }

    private void Start()
    {
        InvokeRepeating("SetPowerToJump", 0, 15f);
    }

    void SetPowerToJump()
    {
        jumpPower += 1f;       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obs")
        {
            Time.timeScale = 0;
            EndGamePanel = 1;            
        }
    }
}