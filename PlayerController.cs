using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float movement;
	private Rigidbody2D rb;
	public GameObject character;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
	{

		movement = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2 (movement * speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space)){
			rb.velocity = new Vector2 (rb.velocity.x, speed);
        }

	}
	// Start is called before the first frame update
}
