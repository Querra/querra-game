using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Animator animator;
    Rigidbody2D rigidBody;
    public float MovementSpeed = 1f;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        HandleAttack();
        HandleMovement();
    }

    private void HandleAttack () {
        animator.SetBool("is_attacking", Input.GetButton("Fire1"));
    }

    private void HandleMovement () {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement != Vector2.zero) {
            animator.SetBool("is_walking", true);
            animator.SetFloat("input_x", movement.x);
            animator.SetFloat("input_y", movement.y);
        }
        else {
            animator.SetBool("is_walking", false);
        }

        rigidBody.MovePosition(rigidBody.position + movement * Time.deltaTime * MovementSpeed);
    }
}