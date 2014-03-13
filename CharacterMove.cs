using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]

public class CharacterMove : MonoBehaviour {
	
	
	
	public float speed = 6.0f; 
	public float jumpSpeed = 8.0f; 
	public float gravity = 20.0f; 
	public float jumpCount = 0.0f; 
	float maxJump = 2.0f; 
	
	
	
	private Vector3 moveDirection = Vector3.zero;
	
	
	
	// Update is called once per frame
	void Update () {
		
		CharacterController controller = GetComponent<CharacterController>();
		
		controller.Move(moveDirection * Time.deltaTime);
		
		// Apply gravity 
		moveDirection.y -= gravity * Time.deltaTime;
		
		if (!controller.isGrounded) {
			
			moveDirection.x = Input.GetAxis("Horizontal")*speed;
		}
		
		else {
			moveDirection = new Vector3(Input.GetAxis("Horizontal")*speed, 0.0f, Input.GetAxis("Vertical")*0.0f); 
			
			jumpCount = 0.0f;
			
		}

		if (jumpCount < maxJump) {
			if (Input.GetButtonDown ("Jump"))  { 
				moveDirection.y = jumpSpeed; 
				jumpCount++;
			} 
		}
	}   
	
}