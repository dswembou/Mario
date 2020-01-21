using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	GameObject getplayerpos;
	GameObject getcamerapos;
	float cameraposx;

	// Use this for initialization
	void Start () {
	
		getplayerpos=GameObject.Find ("Speler");
		getcamerapos=GameObject.Find ("Main Camera");

	}
	
	// Update is called once per frame
	void Update () {
		//transform.position =new Vector2(GetComponent<Rigidbody2D>().velocity.x,0);
		cameraposx=getplayerpos.transform.position.x;

		getcamerapos.transform.position=new Vector3(cameraposx, 0,-10);

	}
}
