﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetConstantVelocity : MonoBehaviour
{
    public Vector3 force;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = force;
    }
}
