using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spread_fire : MonoBehaviour
{ 
        private Random rnd = new Random();
        public int speed;
        public int bullet_count;
        public GameObject obj;
        public float maxError;
        private float error;
        private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
           if (count == speed)
           {
             error = Random.value*maxError*2.0f-maxError;
             //minimum value of -maxError, maximum of +maxError
             SpawnWave();             
             count = 0;
           }
           else
           {count = count + 1;}
        
    }
    void SpawnWave()
    {
        for (float i = 0.0f; i < bullet_count/2; i= i + 1.0f)
        {
              Instantiate (obj, new Vector3((transform.position[0]+i/2), transform.position[1]-1f, 0.0f), Quaternion.AngleAxis(20.0f*i+180.0f+error, Vector3.forward));
              Instantiate (obj, new Vector3((transform.position[0]-i/2), transform.position[1]-1f, 0.0f), Quaternion.AngleAxis(-(20.0f*i+180.0f+error), Vector3.forward));
        
        }
    }
}
