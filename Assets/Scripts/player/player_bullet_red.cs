using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet_red : MonoBehaviour
{
public float bulletspeed = 2;
public Transform target = null;
   Vector3 Angles;

    // Start is called before the first frame update
    void Awake()
    {
      Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position,10);

			//Debug.Log("found " + colliders[0].gameObject);
            foreach(Collider2D col in colliders)
            {
                if (col.tag == "enemy")
                {
                target = col.gameObject.transform;
                break;
                }
            }
      //transform.LookAt(target);
     
     // Debug.Log("initial transform.localRotation : " + transform.localRotation[0] + " , " +transform.localRotation[1] + " , " +transform.localRotation[2]);
      
    }
    void Start()
    {
        if (target != null)
        {
        //makes the bullet face the nearest enemy
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90.0f , Vector3.forward);
        }
        else
        {
        transform.rotation = Quaternion.AngleAxis(0.0f, Vector3.forward);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //moves the bullet forwards in the enemy's direction
        transform.Translate(0.0f,bulletspeed,0.0f);
    }
}
