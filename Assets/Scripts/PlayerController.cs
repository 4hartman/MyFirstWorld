using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float maxSpeed = 15;
	public float jump = 1;

	private Rigidbody rb;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		rb.drag = 0;	
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void FixedUpdate ()
	{
		//if (Input.GetButtonDown ("Horizontal") || Input.GetButtonDown ("Vertical"))
			rb.mass = 0.3f;

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		if(rb.velocity.magnitude > maxSpeed)
		{
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}

		rb.mass = 2.0f;

		if (Input.GetButtonDown("Jump"))
			rb.AddForce (0, jump, 0);

	}
}
