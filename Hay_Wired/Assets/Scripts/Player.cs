using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public string logText="";
	public float speed = 2;
	public float jumpSpeed = 5;
	public float health = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
		float horizontal = Input.GetAxis ("Horizontal");
		bool jump = Input.GetButtonDown ("Jump");
		Collider2D collider = GetComponent<Collider2D>();
		LayerMask groundLayer = LayerMask.GetMask ("Ground");
		bool touchingGround = collider.IsTouchingLayers (groundLayer);
		Vector2 velocity = rigidBody.velocity;
		velocity.x = horizontal * speed;
        //float animatorSpeed = Mathf.Abs(velocity.x);
        //Animator animatorComponent = GetComponent<Animator>();
        //animatorComponent.SetFloat("speed", animatorSpeed);
        SpriteRenderer spriteComponent = GetComponent<SpriteRenderer>();
        spriteComponent.flipX = velocity.x < 0;
        if (jump == true && touchingGround == true) {
			velocity.y = jumpSpeed;
		}
		rigidBody.velocity = velocity;
	}

	public void ApplyDamage (float damageDealt){
		health = health - damageDealt;
	}
}
