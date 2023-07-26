using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
     [HideInInspector] public int score;

     private void Start()
     {
         score = 0;
     }

     // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = score.ToString("000");

    }
}
