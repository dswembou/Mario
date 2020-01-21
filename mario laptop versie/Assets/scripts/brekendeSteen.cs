using UnityEngine;
using System.Collections;

public class brekendeSteen : MonoBehaviour {
	public GameObject steenGeel;
	public GameObject steenRood;
	public GameObject steen;
	bool collisionSpeler;
	int teller;

	// Use this for initialization
	void Start () {
		steenRood.SetActive(false);
		collisionSpeler = false;
		teller = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (collisionSpeler == true) {
			teller++;
		}

		if (teller > 50) {
			steenGeel.SetActive(false);
			steenRood.SetActive(true);
		}

		if (teller > 100) {
			Destroy(steen);
		}


	}//einde update

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			collisionSpeler = true;
			
		}
	}//einde ontrigger

}
