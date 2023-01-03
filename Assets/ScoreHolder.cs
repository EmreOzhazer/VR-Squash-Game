using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    [SerializeField] private GameObject scoreHolder;

    private TextMeshPro Tm;
     
    // Start is called before the first frame update
    void Start()
    {
        Tm = scoreHolder.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void writeText()
    {
        Tm.text += "HELLO ";
    }
}
