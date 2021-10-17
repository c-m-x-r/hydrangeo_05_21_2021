using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_straight : MonoBehaviour
{
   public float bulletspeed= 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(0.0f,bulletspeed,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f,bulletspeed,0.0f);
    }

    public void setspeed (float gspeed)
    {
        bulletspeed = gspeed;

    }
}
