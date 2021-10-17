using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject[] target;
    public float offset = 0.1f;
    public int frequency;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Z))
        {
        //Debug.Log("ready" + "count =" + count);
        
        if(Time.frameCount%(frequency/2) ==0)
        {
         Instantiate (obj [1] , new Vector3(transform.position[0]+ offset/2, transform.position[1]+0.1f, 0.0f), Quaternion.identity);
         Instantiate (obj [1] , new Vector3(transform.position[0]- offset/2, transform.position[1]+0.1f, 0.0f), Quaternion.identity);
        }
           if (count == frequency)
           {
             SpawnHomingBullet();
             
             count = 0;
           }
           else
           {count = count + 1;}
        }
    }
    void SpawnHomingBullet()
    {
    Instantiate (obj [0] , new Vector3(transform.position[0]+ offset, transform.position[1]+0.2f, -1), Quaternion.identity);
    }
}
