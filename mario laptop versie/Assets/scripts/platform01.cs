using UnityEngine;
using System.Collections;

public class platform01 : MonoBehaviour {
	public float movement;




	// Use this for initialization
	void Start () {
		movement = 5;
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<Rigidbody2D>().velocity = new Vector2((GetComponent<Rigidbody2D>().velocity.x)+movement* Time.deltaTime,0);

	}//einde update


	void OnCollisionEnter2D(Collision2D col)
	{
		if((col.gameObject.name == "steenTrigger") || (col.gameObject.name == "steenTrigger1"))
		{
			movement = movement * -1;
		}//einde if collision met Speler

	}
}
