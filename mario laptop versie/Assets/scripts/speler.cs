using UnityEngine;
using System.Collections;

public class speler : MonoBehaviour {

	int horsnelheid = 5;
	int score = 0 ;
	public float speed ;//variable die ik gebruikt voro de animator 0= stil staan positief is naar rechts en negatief is naar links

	public float movespeed;
	public float jumpheight;

	public GUISkin tekstskin;

	private Animator anim;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>(); 
	
	}//einde start


	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}//einde fixed update

	// Update is called once per frame
	void Update () {

		checkGrounded ();
		springen ();
		doubleJump ();
		rechtsLopen ();
		linksLopen ();
		alsJeNergensOpKlikt ();
		alsOnderDeGrond ();

		anim.SetFloat("speed", (Input.GetAxis ("horizontal")));




	}//einde update

	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "coin")
		{
			score = score +1;
		}//einde trigger met coin
	}


	void springen ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpheight);
			GetComponent<AudioSource>().Play();


		}
	}

	void doubleJump ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && !doubleJumped && !grounded) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpheight);
			doubleJumped = true;
			GetComponent<AudioSource>().Play();
		}
	}

	void rechtsLopen ()
	{
		if (Input.GetAxis ("horizontal") > 0) 
		{
			transform.Translate(horsnelheid * Time.deltaTime,0,0);
		}

	}

	void linksLopen ()
	{
		if (Input.GetAxis ("horizontal") < 0) 
		{
			transform.Translate(-horsnelheid * Time.deltaTime,0,0);
		}
//		if (Input.GetKeyDown (KeyCode.A)) {
//			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movespeed, GetComponent<Rigidbody2D> ().velocity.y);
//		}
	}

	void alsJeNergensOpKlikt ()
	{
		if (Input.anyKey == false) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}

	void checkGrounded ()
	{
		if (grounded) {
			doubleJumped = false;
		}
	}

	void alsOnderDeGrond ()
	{
		if (GetComponent<Rigidbody2D> ().position.y < -4) {
			Application.LoadLevel ("level1");
		}
	}

	void OnGUI()
	{
		GUI.skin = tekstskin;
		GUI.Label(new Rect (10, 10, 60, 60 ), "Score");
		GUI.Label(new Rect (70, 10, 60, 60 ), score.ToString());
	}//einde ongui
	

}//einde
