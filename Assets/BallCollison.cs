using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class BallCollison : MonoBehaviour
{
    [SerializeField] private GameObject scoreHolder;

    [SerializeField] private GameObject ballObject,restPosition;
    // Start is called before the first frame update
    private float scorePoint = 0;
    private int groundCount = 2;
    
    
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Area1")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint += 100;
            scoreHolder.GetComponent<TextMeshPro>().text = "SCORE: " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

        }
        if (collision.gameObject.tag == "Area2")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint += 50;
            scoreHolder.GetComponent<TextMeshPro>().text = "SCORE: " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);
        }
        if (collision.gameObject.tag == "Out")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint = 0;
            scoreHolder.GetComponent<TextMeshPro>().text = "SCORE: " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);
            ballObject.transform.position = restPosition.transform.position;
            Debug.Log("OUT!!!");
        }
        if (collision.gameObject.tag == "Ground")
        {
            groundCount--;
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            if (groundCount <= 0)
            {
                scorePoint = 0;
                scoreHolder.GetComponent<TextMeshPro>().text = "SCORE: " + scorePoint;
                LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

                ballObject.transform.position = restPosition.transform.position;

                groundCount += 2;
            }
            Debug.Log("groundCount value: " + groundCount);
        }
        
        
    }


    private float ScorePoint
    {
        get
        {
            return scorePoint;
        }
        set
        {
            scorePoint = value;
        }
    }
    
}
