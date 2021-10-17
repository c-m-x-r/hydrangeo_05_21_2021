using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletgenerator : MonoBehaviour
{
    public float time;
    //time in seconds
    private int timer;
    public int frequency;
    public GameObject bullet;
    private Transform target;
    private Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        timer = (int)time*60;
        target = GameObject.FindGameObjectsWithTag("Player")[0].transform;
        Vector3 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        rotation = Quaternion.AngleAxis(angle - 90.0f , Vector3.forward);
    }

    // Update is called once per frame
    void Update()
    {
      if (timer == 0)
      {
            Destroy(this.gameObject);
      }
         if (Time.frameCount%frequency==0)
        {
        Instantiate (bullet, new Vector3((transform.position[0]), transform.position[1], 0.0f), rotation);
        }

     timer--;
    }
}
