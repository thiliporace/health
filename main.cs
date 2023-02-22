using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
   //[SerializeField] TextMeshProUGUI m_Object;
   private float maxHealth = 100f;
   private Rigidbody player;
   private float speed;
   
    void Start()
    {
        player = GetComponent<Rigidbody>();
        speed = GetComponent<PlayerMovement>().playerSpeed;
    }
    
    void Update()
    {
        //Debug.Log(maxHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            maxHealth -= 10f;
        }

        if (other.tag == "Speed")
        {
            speed += 1000f;
            Debug.Log("azu");
        }
    }
}
