using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    public float MagnusConst = .005f;

    private Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 force = MagnusConst * Vector3.Cross(r.velocity, r.angularVelocity);
        r.AddRelativeForce(force);
    }
}
