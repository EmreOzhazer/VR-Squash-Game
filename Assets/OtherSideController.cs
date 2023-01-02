using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSideController : MonoBehaviour
{
   
    [SerializeField] Rigidbody m_Rigidbody;
    [SerializeField] float m_Thrust;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        OnCollisionEnter();
    }

    void OnCollisionEnter()
    {
        m_Rigidbody.AddForce(-transform.up * m_Thrust * 0.75f + -transform.forward * m_Thrust * 2f);
    }
}
