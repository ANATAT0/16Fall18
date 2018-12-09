using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GingerbreadCharacterMover : MonoBehaviour
{
	public float Speed;
	public float JumpForce;
	private float moveInput;

	private Rigidbody2D rb;
	private Animator anim;

	private bool facingRight = true;
	
	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	private int extraJumps;
	public int extraJumpValue;




	void Start()
	{
		extraJumps = extraJumpValue;
		rb = GetComponent<Rigidbody2D>();

		anim = GetComponent<Animator>();
	}


	void FixedUpdate()
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * Speed, rb.velocity.y);

		if (facingRight == false && moveInput > 0)
		{
			Flip();
		}
		else if (facingRight == true && moveInput < 0)
		{
			Flip();
		}
	}


	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}
	

	void Update()
	{
		if (isGrounded == true)
		{
			extraJumps = extraJumpValue;
		}


		if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
		{
			rb.velocity = Vector2.up * JumpForce;
            extraJumps--;
		}
		else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
		{
			rb.velocity = Vector2.up * JumpForce;
		}
		
	}
}