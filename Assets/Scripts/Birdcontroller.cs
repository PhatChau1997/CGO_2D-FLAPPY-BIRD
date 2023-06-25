using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdcontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumbForce;
    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumbForce;
        }
    }
}
