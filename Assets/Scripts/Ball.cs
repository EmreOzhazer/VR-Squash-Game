using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody r;
    private bool isHit = false;
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit && r.velocity.magnitude < 1f) ;
           // Destroy(this.gameObject);
    }

    void OnCollisionEnter()
    {
        isHit = true;
    }
}
