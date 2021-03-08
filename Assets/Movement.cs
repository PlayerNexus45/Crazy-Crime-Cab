using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float acceleration = 5f;
    public float steeringPower = 5f;

    public Rigidbody2D rb;

    public float direction, steering, speed;

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector2.down * speed);
        }        

        steering = -Input.GetAxis("Horizontal");
        speed = Input.GetAxis("Vertical") * acceleration;
        direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up)));
        rb.rotation += steering * steeringPower * rb.velocity.magnitude * direction;

        rb.AddRelativeForce(Vector2.up * speed);

        rb.AddRelativeForce(-Vector2.right * rb.velocity.magnitude * steering / 2);
    }

    void OnCollisionEnter2D(Collision2D cl)
    {
        rb.AddRelativeForce(Vector2.zero);

        rb.AddRelativeForce(Vector2.down * 2);
    }
}
