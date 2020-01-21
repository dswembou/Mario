using UnityEngine;
using System.Collections;

public class koopatrooper : MonoBehaviour {
	public float movement;
	private Animator anim;

	// Use this for initialization
	void Start () {
		movement = 3;
		anim = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(movement * Time.deltaTime,0,0);
		anim.SetFloat("speed", (movement));
	
	}//einde update

	void OnCollisionEnter2D(Collision2D col)
	{
		if((col.gameObject.tag == "steen") || (col.gameObject.tag == "enemy")		)

		{
			movement = movement * -1;
		}//einde if collision met Speler

		if (movement > 0) {

			//print("hier moet animatie recht komen");
			//GameObject.animation.Play("koopa_r");


		}
		if (movement < 0) {
			//print("hier moet animatie links komen");
			
		}


		}//einde if collision met Speler
		
	}//einde 
