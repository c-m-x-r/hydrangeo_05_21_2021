using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_control : MonoBehaviour
{
    private float error;
    public GameObject[] spawn; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        error = Random.value*2.0f-1.0f;
        
        if (Input.GetKey(KeyCode.Q) & Time.frameCount % 13 == 0)
         {
              //spawn enemies from the right      
              Instantiate (spawn [0] , new Vector3(-1.0f,12.0f + error, 0.0f), Quaternion.identity);
         }
         
         if (Input.GetKey(KeyCode.R) & Time.frameCount % 13 == 0)
         {
              //spawn enemies from the left
              Instantiate (spawn [1] , new Vector3(11.0f,12.0f + error, 0.0f), Quaternion.identity);
         }

         if (Input.GetKey(KeyCode.S) & Time.frameCount % 50 == 0)
         {
              
              Instantiate (spawn [5] , new Vector3(5.0f,12.0f, 0.0f), Quaternion.identity);
         }




         if (Input.GetKey(KeyCode.W) & GameObject.FindGameObjectsWithTag("enemy").Length == 0)
         {
              //spawn spread fire enemy
              Instantiate (spawn [2] , new Vector3(5.3f,11.5f + error, 0.0f), Quaternion.identity);
         }

         if (Input.GetKey(KeyCode.E) & GameObject.FindGameObjectsWithTag("enemy").Length == 0)
         {
         //spawn spell1 enemy
            Instantiate (spawn [3] , new Vector3(5.3f,10f + error, 0.0f), Quaternion.identity);
         }

         if (Input.GetKey(KeyCode.T) &  GameObject.FindGameObjectsWithTag("Player").Length == 0)
         {
             // respawn player
             Instantiate (spawn [4] , new Vector3(5.0f,5.0f + error, 0.0f), Quaternion.identity);
         }
         if (Input.GetKey(KeyCode.F) &  GameObject.FindGameObjectsWithTag("enemy").Length == 0)
         {
          Instantiate (spawn [6] , new Vector3(5f,10f, 0.0f), Quaternion.identity);
         }

          //back to menu
         if (Input.GetKey(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("menu");
        }

    }
}
