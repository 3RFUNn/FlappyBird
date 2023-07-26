using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GreenPipes : MonoBehaviour
{
    public void randomspawn()
    {
        transform.position = new Vector2(transform.position.x,Random.Range(-2f, 2.9f));
    }
    void Start()
    {
        randomspawn();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-2f * Time.deltaTime, 0, 0);
        if (transform.position.x <= -15f)
        {
            transform.position = new Vector2(15f,Random.Range(-2f, 2.9f));
        }
    }
}
