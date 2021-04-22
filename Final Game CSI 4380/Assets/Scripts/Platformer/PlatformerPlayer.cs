using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private int jumps = 2;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && jumps > 0)
        {
            jumps--;
            rb.AddForce(Vector2.up * 300);
            Debug.Log(jumps);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Mathf.Abs(rb.velocity.x) < 5f)
        {
            transform.position = new Vector3(transform.position.x - 5f * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow) && Mathf.Abs(rb.velocity.x) < 5f)
        {
            transform.position = new Vector3(transform.position.x + 5f * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.rigidbody.tag);
        if (collision.rigidbody.tag == "Ground")
        {
            jumps = 2;
        }
    }

}
