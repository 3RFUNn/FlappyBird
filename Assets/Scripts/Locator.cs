using UnityEngine;
public class Locator : MonoBehaviour
{
    
    void FixedUpdate()
    {
        transform.position += new Vector3(-1.5f * Time.deltaTime, 0, 0);
        if (transform.position.x <= -15.5f)
        {
            transform.position = new Vector3(24f, transform.position.y, 0);
        }
    }
}
