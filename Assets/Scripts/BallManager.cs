using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject BallPrefab;

    [HideInInspector]
    public GameObject CurrentBall;

    public static BallManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CurrentBall == null)
            CurrentBall = Instantiate(BallPrefab, transform.position, transform.rotation) as GameObject;
    }
}
