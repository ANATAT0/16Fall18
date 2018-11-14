using UnityEngine;

private Animator anims;
public float speed;

	void Start (){
	{
		Animas = GetComponent<Animator>();
	}


	void Update () 
	{
		anims.SetFloat("Speed", speed);	
	}
}
