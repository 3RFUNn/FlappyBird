using System;

using UnityEngine;

using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Point _point;
    private float time = 2;
    [SerializeField] GameObject replay;
    [SerializeField] private GameObject _audio;
    [SerializeField] private GameObject _quit;
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update(){
        if(time >= 0){
                time -= Time.deltaTime;
                rb.GetComponent<Rigidbody2D>().gravityScale = 0;

        }else
        {
            rb.GetComponent<Rigidbody2D>().gravityScale = 1.7f;
            if (Input.GetKeyDown(KeyCode.Mouse0)) 
            {
                rb.AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D _col)
    {
        if(_col.gameObject.CompareTag("Wall"))
        {
            Time.timeScale = 0;
            replay.SetActive(true);
            _audio.SetActive(true);
            _quit.SetActive(true);
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Score"))
        {
            _point.score++;
        }
    }

    public void replaygame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }
}
