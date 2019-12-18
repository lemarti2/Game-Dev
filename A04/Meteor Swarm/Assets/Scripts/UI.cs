using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
    
{
    public static Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    startButton = GetComponent<Button>();
    startButton.onClick.AddListener(() => Difficulty());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Difficulty()
    {
        if (startButton.tag == "Easy")
        {
            Spawn.spawnTime = 0.001f;
            print("easy");
        }
        else if (startButton.tag == "Medium")
        {
            Spawn.spawnTime = 0.1f;
        }
        else if (startButton.tag == "Hard")
        {
            Spawn.spawnTime = 0.01f;
        }
        Time.timeScale = 1;
    }
}
