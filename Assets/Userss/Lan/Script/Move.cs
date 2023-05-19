using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float jumpForce = 10f; // ÌøÔ¾Á¦Á¿
    private Rigidbody2D rb;

    private Collider2D coli;

    public float speed=5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))

        {

            transform.position += new Vector3(-0.1f, 0, 0);

        }

        else if (Input.GetKey(KeyCode.D))

        {

            transform.position += new Vector3(0.1f, 0, 0);

        }

            

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }


}
