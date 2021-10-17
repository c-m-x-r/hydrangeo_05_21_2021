using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		//if the object that triggered the event is tagged player
		if (other.tag == "Player") 
		{
			//other.gameObject.parent.transform.Translate(-other.x_movement,-other.y_movement);
			//Debug.Log("epic embed fail");
		}
					
		
	
			else if (other.gameObject.transform.parent) 
			{
				Destroy (other.gameObject.transform.parent.gameObject);
				//Debug.Log("destroyed parent");
			} 
			else
			{
				Destroy (other.gameObject);		
				//Debug.Log("destroyed child");
			}

	}

}
