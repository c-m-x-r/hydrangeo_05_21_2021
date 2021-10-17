using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox_enemy : MonoBehaviour
{
      public int hitpoints = 100;
    // Start is called before the first frame update
    void Start()
    {
       
    }
void OnTriggerEnter2D(Collider2D other)
	{
	 
			if (other.tag == "bullet") 
			{
				Destroy (other.gameObject);
				hitpoints = hitpoints -1;
				Debug.Log("hit " + "hp: " + hitpoints);
			} 
			else
			{
				Debug.Log("ow");
			}
			
			if (hitpoints == 0)
			{
				Debug.Log("dead");
				Destroy (this.gameObject);
			}

	}
}
