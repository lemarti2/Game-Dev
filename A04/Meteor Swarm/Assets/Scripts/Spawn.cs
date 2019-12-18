using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject meteor;
    public static float spawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addMeteor", 0, spawnTime);
        print(spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void addMeteor()
    {
        var rd = GetComponent<Renderer>();
        float x1 = transform.position.x - rd.bounds.size.x/2;
        float x2 = transform.position.x + rd.bounds.size.x/2;
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(meteor, spawnPoint, Quaternion.identity);
    }
}
