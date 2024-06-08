using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class player1 : MonoBehaviour
{
    public LayerMask layerCompatible;

    public float speed;
    public float jumpForce;
    public float distanceGround;
    private Rigidbody2D rb;
    private float horizontal;
    public bool isGround;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");

        Debug.DrawRay(transform.position, Vector2.down * distanceGround, Color.red);

        if (Physics2D.Raycast(transform.position, Vector2.down, distanceGround, layerCompatible))
        {
            isGround = true;
            Debug.Log("Esta en el suelo");
        }
        else isGround = false;

        if (Input.GetKeyDown(KeyCode.W) && isGround)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, rb.velocity.y);
    }
}
