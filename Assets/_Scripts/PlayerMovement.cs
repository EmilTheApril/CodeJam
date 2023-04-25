using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        Input.gyro.enabled = true;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement(GetPhoneRotation());
    }

    public float GetPhoneRotation()
    {
        return Input.gyro.attitude.y;
    }

    public void Movement(float input)
    {
        rb.velocity = new Vector2(speed * input, 0);
    }
}
