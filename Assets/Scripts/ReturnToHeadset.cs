using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToHeadset : MonoBehaviour
{
    public Transform head;

    private void OnCollisionEnter()
    {
        Rigidbody r = BallManager.Instance.CurrentBall.GetComponent<Rigidbody>();
        r.angularVelocity = Vector3.zero;
        Vector3 dir = (head.position - r.transform.position).normalized;
        r.velocity = dir * 35f;
        //ATTACH TO THE WALL
    }
}
