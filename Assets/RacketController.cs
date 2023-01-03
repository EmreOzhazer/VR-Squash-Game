using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RacketController : MonoBehaviour
{
    [SerializeField] Rigidbody m_Rigidbody; 
    [SerializeField] float m_Thrust;

    [SerializeField] AudioSource hitEffect;
    
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //OnCollisionEnter();
    }


    void OnCollisionEnter(Collision collision)
    {
        m_Rigidbody.AddForce(transform.up * m_Thrust * 0.75f + transform.forward * m_Thrust * 2f);

        if (collision.gameObject.tag == "Ball")
        {
            //m_Rigidbody.AddForce(transform.up * m_Thrust * 0.75f + transform.forward * m_Thrust * 2f);

            soundEffect();
        }
        
    }
    

    void soundEffect()
    {
        hitEffect.gameObject.GetComponent<AudioSource>().Play();
        Debug.Log("Effect played");
    }
}