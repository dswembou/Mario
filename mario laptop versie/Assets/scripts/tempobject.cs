using UnityEngine;
using System.Collections;

public class tempobject : MonoBehaviour {
	float tijd=15f;
	public GameObject coin;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		tijd-=Time.deltaTime;
		if (tijd<0)
		{
			coin.SetActive(false);
		}


	}//einde update


	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player")
		{
				Destroy(coin);
			
		}
}
}
