using UnityEngine;
using System.Collections;

public class vraagtekenScript : MonoBehaviour {

	public GameObject vraagtekenSprite;
	public GameObject steen;
	public GameObject geldspawn;
	public GameObject trigger;



	// Use this for initialization
	void Start () {
		steen.SetActive(false);
		geldspawn.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}//einde update

	void OnCollisionEnter2D(Collision2D other)
	{
		steen.SetActive(true);
		geldspawn.SetActive(true);
		Destroy (trigger);

	}
}
