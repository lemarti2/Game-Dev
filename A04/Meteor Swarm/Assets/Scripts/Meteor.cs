using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public static float speed = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        var r2d = GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(Random.Range(-1.0f, 1.0f), speed);
        r2d.angularVelocity = Random.Range(-200.0f, 200.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
         tag = collision.gameObject.tag;

        /*if(tag == "Finish")
        {
            Destroy(this.gameObject);
        }*/
        if(tag == "bullet")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        if(tag == "spaceship")
        {
            Time.timeScale = 0;
        }
    }
}
