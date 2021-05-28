﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;

    private Animator ani;
    public float PlayerSpeed;
    public float PlayerRotateSpeed;

    void Start()
    {
        ani = GetComponent<Animator>();

    }
    void Update()
    {
        translation = Input.GetAxis("Vertical") * PlayerSpeed;

        rotation = Input.GetAxis("Horizontal") * PlayerRotateSpeed;

        transform.Translate(0, 0, translation*Time.deltaTime);
        transform.Rotate(0, rotation*Time.deltaTime, 0);
        if (translation != 0 || rotation != 0)
            ani.SetBool("walk", true);
        else
            ani.SetBool("walk", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            ani.SetTrigger("damage");
            GameManager.instance.AddScore(-1);
        }

        if(collision.collider.tag == "Enermy")
        {
            ani.SetTrigger("die");
            GameManager.instance.OnPlayerDead();
        }
    }
}