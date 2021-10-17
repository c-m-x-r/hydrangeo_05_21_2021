using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell1 : MonoBehaviour
{
    private GameObject[] target;
    public GameObject[] bullet;
    private float timer;
    private float i = 0.0f;
    public float time;
    public float ring_number;
    public int radius;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        timer = ring_number*2-time;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        target = GameObject.FindGameObjectsWithTag("Player");

        if (target.Length > 0)
        {
        //summon 20 bullets around the player
        //position based on a circle, x and y
     
            if (timer > 0 & timer%2==0)
            {
            x = target[0].transform.position[0]+Mathf.Sin(i/ring_number*2f*Mathf.PI)*radius;
            y = target[0].transform.position[1]+Mathf.Cos(i/ring_number*2f*Mathf.PI)*-radius;
            
             Vector3 direction = target[0].transform.position - new Vector3(x,y,0.0f);
            float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
            
            
            Instantiate (bullet [0] , new Vector3( x, y , 0.0f), Quaternion.AngleAxis(angle - 90.0f , Vector3.forward));
            i = i+1.0f;
            }

        }





           if (timer == ring_number*2)
           {
                  timer = timer - time;
                  i = 0.0f;
           }
           else
            {
            timer= timer + 1;
            }

            //transform.Translate(Mathf.Sin(Time.frameCount/100),0.0f,0.0f);

    }
}
