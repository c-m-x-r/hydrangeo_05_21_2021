using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_sin : MonoBehaviour
{
   public float bulletspeed;
   public float amplitude;
   public float wavelength;
   private float counter=0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Mathf.Cos(counter)*0.02f,bulletspeed,0.0f);
        counter = counter + 0.04f;
    }

}
