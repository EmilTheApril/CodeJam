using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement(GetPhoneRotation());
    }

    public float GetPhoneRotation()
    {
        return Input.acceleration.x;
    }

    public void Movement(float input)
    {
        if (transform.position.x > -2 && GetPhoneRotation() < 0)
        {
            rb.velocity = new Vector2(speed * input, 0);
        }
        else if (transform.position.x < 2 && GetPhoneRotation() > 0)
        {
            rb.velocity = new Vector2(speed * input, 0);
        }
        else rb.velocity = Vector2.right * 0;
    }
}
