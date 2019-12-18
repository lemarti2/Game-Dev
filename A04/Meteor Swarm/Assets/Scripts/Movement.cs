using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * .15f, 0.0f, 0.0f);
        if (transform.position.x <= -6.1f)
        {
            transform.position = new Vector3(6.1f, -4.0f, 0.0f);
        }
        if (transform.position.x >= 6.2f)
        {
            transform.position = new Vector3(-6.2f, -4.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(bullet, transform.position, Quaternion.identity);
            
        }
    }
}
