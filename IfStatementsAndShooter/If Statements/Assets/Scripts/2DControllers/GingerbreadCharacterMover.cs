using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GingerbreadCharacterMover : MonoBehaviour
{
	//Floats
	public float Speed;
	public float JumpForce;
	private float moveInput;

	//Animators
	private Rigidbody2D rb;
	private Animator anim;

	//Bools
	private bool facingRight = true;
	private bool Attack;
	private bool isGrounded;
	
	//Ground
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

	//Jumps
	private int extraJumps;
	public int extraJumpValue;

	//Stats
	public int CurrentHealth;
	public int MaxHealth = 7;



	void Start()
	{
		extraJumps = extraJumpValue;
		rb = GetComponent<Rigidbody2D>();

		anim = GetComponent<Animator>();

		CurrentHealth = MaxHealth;
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

		Attacks();
		
		ResetValues();
		
	}

	private void Attacks()
	{
		if (Attack)
		{
			anim.SetTrigger("Attack");
		}
	}


	private void HandleInput()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			Attack = true;
		}
	}
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;
	}

	public void Damage(int dmg)
	{
		CurrentHealth -= dmg;
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

		HandleInput();

		if (CurrentHealth > MaxHealth)
		{
			CurrentHealth = MaxHealth;
		}

		if (CurrentHealth <= 0)
		{
			Die();
		}

			
	
		
	}

	private void ResetValues()
	{
		Attack = false;
	}

	void Die()
	{
		
		//Restart
		Application.LoadLevel(Application.loadedLevel);
	}
}

	