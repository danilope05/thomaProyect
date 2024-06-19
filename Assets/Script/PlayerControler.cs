using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    PlayerControler pc;
    public bool isGround;
    public float distanceGround;
    public LayerMask layerCompatible;
    public float speed;
    public Rigidbody2D rd;
    public float horinzontal;
    public float jumpForce;
    Vector3 StartPo;


    public void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartPo = this.transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        horinzontal = (Input.GetAxis("Horizontal"));

        Debug.DrawRay(transform.position, Vector3.down * distanceGround, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, distanceGround, layerCompatible))
        {
            isGround = true;
            Debug.Log("Esta en el suelo");
        }
        else isGround = false;
        if (Input.GetKeyDown(KeyCode.W) && isGround)
        {
            rd.AddForce(Vector2.up * jumpForce);
        }
    }
    private void FixedUpdate()
    {
        rd.velocity = new Vector2(horinzontal * speed, rd.velocity.y);
    }
    public void ResetPosition()
    {
        this.transform.position = StartPo;
    }
}
