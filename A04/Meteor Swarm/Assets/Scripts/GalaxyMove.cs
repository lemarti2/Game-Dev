using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyMove : MonoBehaviour
{
    public float start = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, -.03f, 0.0f);
        if(transform.position.y <= -5.0f)
        {
            transform.position = new Vector3(0.0f, 5.0f, 0.0f); 
        }
    }
}
