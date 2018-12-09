using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GingerbreadCharacterMover : MonoBehaviour
{
	private float speed = 3.0f;
	public float jumpspeed = 4.0f;
	public float gravity = 9.81f;
	private float moveInput;

	private Rigidbody2D rb;
	private Animator anim;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}


	void FixedUpdate()
	{
		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
		
		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
	}
}
