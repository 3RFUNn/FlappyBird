using Unity.Mathematics;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(-2f * Time.deltaTime, 0, 0);
        if (transform.position.x <= -10f)
        {
            transform.position = new 
                Vector3(GameObject.Find("base2").GetComponent<SpriteRenderer>().bounds.max.x + 
                        GameObject.Find("base2").GetComponent<SpriteRenderer>().bounds.max.x -
                                 GameObject.Find("base2").GetComponent<SpriteRenderer>().bounds.min.x - 0.1f, 
                    GameObject.Find("base2").GetComponent<SpriteRenderer>().bounds.center.y, 0);
        }
    }
}

