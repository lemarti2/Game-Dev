using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float start = 0.0f;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        var r2d = GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(0.0f, speed);
        //r2d.AddForce(new Vector2(0, 700f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
