using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover2 : MonoBehaviour
{

	private CharacterController controller;
	private Vector3 position;
	public float Speed = 3.0f;
	private float JumpSpeed = 4.0f;
	public float Gravity = 9.81f;

	private Animator anim;
	
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
		
		if (controller.isGrounded)
		{
			position.x = Speed * Input.GetAxis("Horizontal");


			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}

		}
		
		
		position.y -= Gravity *Time.deltaTime;
		
		controller.Move(position * Time.deltaTime);
	}
}
