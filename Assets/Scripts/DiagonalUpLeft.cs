﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalUpLeft : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 9.0f;
    float origX;
    public float distance = 10.0f;

    // Use this for initialization
    void Start()
    {
        origX = transform.position.x;
        useSpeed = -directionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (origX - transform.position.x > distance)
        {
            useSpeed = directionSpeed; //flip direction
        }
        else if (origX - transform.position.x < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(useSpeed * Time.deltaTime, -useSpeed * Time.deltaTime, 0);
    }
}
