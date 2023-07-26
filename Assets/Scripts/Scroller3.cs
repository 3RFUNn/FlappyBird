using Unity.Mathematics;
using UnityEngine;

public class Scroller3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        transform.position += new Vector3(-2f * Time.deltaTime, 0, 0);
        if (transform.position.x <= -10f)
        {
            transform.position = new 
                Vector3(GameObject.Find("base1").GetComponent<SpriteRenderer>().bounds.max.x + 
                        GameObject.Find("base1").GetComponent<SpriteRenderer>().bounds.max.x -
                                 GameObject.Find("base1").GetComponent<SpriteRenderer>().bounds.min.x - 0.1f, 
                    GameObject.Find("base1").GetComponent<SpriteRenderer>().bounds.center.y, 0);
        }
    }

}
