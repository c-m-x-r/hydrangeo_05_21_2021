using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_enemy_fire : MonoBehaviour
{   
    public int frequency;
    public float maxError;
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount%frequency==0)
        {
        Instantiate (obj, new Vector3((transform.position[0]), transform.position[1]-0.5f, 0.0f), Quaternion.AngleAxis(180.0f+Random.value*maxError*2.0f-maxError, Vector3.forward));
        }

    }
}
