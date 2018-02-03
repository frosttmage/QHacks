using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SimplePlatformController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = false;
	public float moveForce = 365f;
	public float maxSpeed = 8f;
	public float jumpForce = 1000f;
	//public Text CountText; 
	public Transform groundCheck;
	//public Text winText;   
	//[HideInInspector] 
	public double count;



	private bool grounded = false;
	private Animator anim;
	private Rigidbody2D rb2d;


	// Use this for initialization
	void Awake () 
	{
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		//SetCountText()
	}

	// Update is called once per frame
	void Update () 
	{
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (Input.GetButtonDown("Jump") && grounded)
		{
			jump = true;
		}
	}

	void FixedUpdate()
	{
		float h = Input.GetAxis("Horizontal");

		anim.SetFloat("Speed", Mathf.Abs(h));

	//	if (h * rb2d.velocity.x < maxSpeed)
	//		rb2d.AddForce(Vector2.right * h * moveForce);

	//	if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
		rb2d.velocity = new Vector2(Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
		/*
		if (h > 0 && !facingRight)
			Flip ();
		else if (h < 0 && facingRight)
			Flip ();
		*/
		if (jump)
		{
			anim.SetTrigger("Jump");
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}

	/*
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}*/

	void OnTriggerEnter2D(Collider2D other) 
	{
		//Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
		if (other.gameObject.CompareTag("barrier")) {
			count = count - 0.5;
			Debug.Log (gameObject.name);
			//SetCountText()
		}
		else {
			count = count + 1;
			Debug.Log (gameObject.name);
			//SetCountText()
		}

		//SetCountText ();
	}

	/*
	void SetCountText()
	{
		//Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
		CountText.text = count.ToString ();

		//Check if we've collected all 12 pickups. If we have...
		if (count == 5)
			//... then set the text property of our winText object to "You win!"
			//winText.text = "You win!";
		if (count == -5)
			//winText.text = "You lose!";
	}
	*/
}