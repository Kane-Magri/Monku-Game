using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public float jumpSpeed;

    private bool isJumping;
    private float move;
    private Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        move = Input.GetAxis("Horizontal");

        rb. velocity = new Vector2 (move* playerSpeed, rb.velocity.y);

        if (move < 0 )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }else if (move > 0)
        {
        transform.eulerAngles = new Vector3 (0, 0, 0);
        }


        if(Input.GetButtonDown("Jump")&& !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x,jumpSpeed));
            isJumping = true;
            SoundManagerScript.PlaySound ("jump");
            
        }
    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("TileMap"))
        {
            isJumping = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
}

