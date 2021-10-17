using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class hitbox_player : MonoBehaviour
{
    public int life;
    public AudioClip clip;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = gameObject.AddComponent<AudioSource>();
        sound.clip = clip;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (life == 0)
        {
        Destroy(this.transform.parent.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
	{
    life --;
     Debug.Log("aieeeeeeee  " + life);
      
     Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position,2.5f);

			Debug.Log("found " + colliders[0].gameObject);
            foreach(Collider2D col in colliders)
            {
                if (col.tag == "bullet_enemy")
                {
                //col.gameObject.transform.eulerAngles = -col.gameObject.transform.eulerAngles;
                Destroy(col.gameObject);
                }
                
            }

            sound.Play();
            
    }
}
