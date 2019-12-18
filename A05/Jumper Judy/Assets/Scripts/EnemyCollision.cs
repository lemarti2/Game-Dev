using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "McCree" && this.gameObject.tag == "Boss")
        {
            Destroy(this.gameObject);
            GameManager.score += 100;
        }
        else if (collision.gameObject.tag == "McCree")
        {
            Destroy(this.gameObject);
            GameManager.score += 10;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "McCree")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Gameover");

        }
    }
}
