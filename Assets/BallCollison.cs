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

    public Rigidbody r;
    
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Area1")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint += 10;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

        }
        if (collision.gameObject.tag == "Area2")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint += 5;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);
        }
        if (collision.gameObject.tag == "Out")//can be removed
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("HIT !!!!!");
            scorePoint = 0;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
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
                scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
                LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

                ballObject.transform.position = restPosition.transform.position;
                
                r.velocity = new Vector3(0, 0, 0); //when ball position resetted it stop the balls movement
                groundCount += 2;
            }
            Debug.Log("groundCount value: " + groundCount);
            
        }

        if (collision.gameObject.tag == "100")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("hit on score area");
            scorePoint += 100;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

        }
        if (collision.gameObject.tag == "200")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("hit on score area");
            scorePoint += 200;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

        }
        if (collision.gameObject.tag == "250")
        {
            LeanTween.cancel(scoreHolder);
            Debug.Log("hit on score area");
            scorePoint += 250;
            scoreHolder.GetComponent<TextMeshPro>().text = " " + scorePoint;
            LeanTween.scale(scoreHolder, new Vector3(0.06f, 0.06f, 0.06f), 1f).setEase(LeanTweenType.punch);

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
