using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (this.gameObject.tag == col.gameObject.tag)
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Debug.Log("collision detected!");
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    
}
