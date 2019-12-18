using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float jumpHeight = 8.0f;
    public static bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * .12f, 0.0f, 0.0f);
        if (Input.GetKeyDown(KeyCode.Space)&&(isJumping == false))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
        else if(collision.gameObject.tag == "Death")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Gameover");
        }
        else if(collision.gameObject.tag == "Chest1")
        {
            SceneManager.LoadScene("Lvl2");
        }
        else if (collision.gameObject.tag == "Chest2")
        {
            SceneManager.LoadScene("Lvl3");
        }
        else if (collision.gameObject.tag == "Chest3")
        {
            SceneManager.LoadScene("Win");
        }
        else if (collision.gameObject.tag == "Spikes")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Gameover");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            GameManager.score += 1;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = true;
        }
    }
}
