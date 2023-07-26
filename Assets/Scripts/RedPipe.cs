using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedPipe : MonoBehaviour
{
    // Start is called before the first frame update
    

   

    void Update()
    {
        transform.position += new Vector3(-2f * Time.deltaTime, 0, 0);
        if (transform.position.x < -25f)
        {
            gameObject.SetActive(false);
            
        }
    }
}
