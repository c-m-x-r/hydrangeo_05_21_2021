using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class normal_mode : MonoBehaviour
{
    
    public GameObject[] spawn; 
    public int firstwavetime;
    public int secondwavetime;
    private int progress = 0;
    private float error;

    //tracks the players progress throught the level, incrementing per wave they clear

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         error = Random.value*2.0f-1.0f;
        //first wave of enemies
        if (firstwavetime > 0)
        {
            if (Time.frameCount % 26 == 0)
            {
            Instantiate (spawn [0] , new Vector3(-0.5f,12.0f + error, 0.0f), Quaternion.identity);
            Instantiate (spawn [1] , new Vector3(10.5f,12.0f + error, 0.0f), Quaternion.identity);
            }
            firstwavetime--;
        }
        if (firstwavetime == 0 & progress == 0)
        {
          progress = 1;
        }

        //first boss enemy

        if (progress == 1 & GameObject.FindGameObjectsWithTag("enemy").Length == 0 )
        {
            progress=2;
            Instantiate (spawn [2] , new Vector3(5.3f,11.5f + error, 0.0f), Quaternion.identity);
            
        }

        if (progress == 2 & GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            progress = 3;
            Instantiate (spawn [5] , new Vector3(3.0f,12.0f, 0.0f), Quaternion.identity);
            Instantiate (spawn [5] , new Vector3(7.0f,12.0f, 0.0f), Quaternion.identity);
        }

        
        //second wave of enemy
        if (progress == 3 & secondwavetime > 0)
        {
             if (Time.frameCount % 50 == 0)
            {
            Instantiate (spawn [0] , new Vector3(-0.5f,12.0f + error, 0.0f), Quaternion.identity);
            Instantiate (spawn [1] , new Vector3(10.5f,12.0f + error, 0.0f), Quaternion.identity);
            }
            secondwavetime--;
        }
        
        if (progress == 3 & secondwavetime == 0 & GameObject.FindGameObjectsWithTag("enemy").Length == 0)
        {
            progress = 4;
            Instantiate (spawn [3] , new Vector3(5.3f,10f + error, 0.0f), Quaternion.identity);
        }

         if (progress == 4 & GameObject.FindGameObjectsWithTag("enemy").Length == 0)
         {
         progress = 5;
         Instantiate (spawn [6] , new Vector3(5f,10f, 0.0f), Quaternion.identity);
         }

         //back to menu
         if (Input.GetKey(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
