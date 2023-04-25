using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] float leftSideOfScreen;
    [SerializeField] float rightSideOfScreen;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        leftSideOfScreen = Camera.main.transform.position.x - Camera.main.orthographicSize * Screen.width / Screen.height;
        rightSideOfScreen = Camera.main.transform.position.x + Camera.main.orthographicSize * Screen.width / Screen.height;
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
        if (transform.position.x > leftSideOfScreen && GetPhoneRotation() < 0)
        {
            rb.velocity = new Vector2(speed * input, 0);
        }
        else if (transform.position.x < rightSideOfScreen && GetPhoneRotation() > 0)
        {
            rb.velocity = new Vector2(speed * input, 0);
        }
        else rb.velocity = Vector2.right * 0;
    }
}
