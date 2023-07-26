
using UnityEngine;
using Unity.Mathematics;
public class Scroller2 : MonoBehaviour
{
    
    
    private void FixedUpdate()
        {
            transform.position += new Vector3(-2f * Time.deltaTime, 0, 0);
            if (transform.position.x <= -10f)
            {
                transform.position = new 
                    Vector3(GameObject.Find("base").GetComponent<SpriteRenderer>().bounds.max.x + 
                            GameObject.Find("base").GetComponent<SpriteRenderer>().bounds.max.x -
                                     GameObject.Find("base").GetComponent<SpriteRenderer>().bounds.min.x - 0.1f, 
                        GameObject.Find("base").GetComponent<SpriteRenderer>().bounds.center.y, 0);
            }
        }
    }

