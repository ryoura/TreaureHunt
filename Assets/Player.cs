﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;

    Rigidbody2D rd;

    Animator anima;
    float Walk;
    Vector2 vector2;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float verticalKey = Input.GetAxis("Vertical");

        if (horizontalKey > 0)
        {
            rd.velocity = new Vector2(speed, 0);
            anima.SetFloat("Speed",10f);
        }
        else if (horizontalKey < 0)
        {
            rd.velocity = new Vector2(-speed, 0);
            anima.SetFloat("Speed", 0f);

        }
        else if (verticalKey > 0)
        {
            rd.velocity = new Vector2(0, speed);
        }
        else if (verticalKey < 0)
        {
            rd.velocity = new Vector2(0, -speed);
        }
        else
        {
            rd.velocity = Vector2.zero;
            anima.SetFloat("Speed", 0f);
        }
    }
}
