using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    public float xspeed;
    public float yspeed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    transform.Translate(xspeed*0.05f,yspeed*0.05f,0.0f);  
    }
}
