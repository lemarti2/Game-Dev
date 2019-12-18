using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    public Transform target;
    public float xmin = -3.0f;
    public float xmax = 20.0f;
    public float ymin = -5.0f;
    public float ymax = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x,xmin, xmax),Mathf.Clamp(target.position.y, ymin, ymax), transform.position.z);
    }
}
