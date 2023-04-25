using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rd;
    [SerializeField] private float speed;

    private void Awake()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        Movement(GetPhoneRotation());
    }

    public float GetPhoneRotation()
    {
        return Input.gyro.attitude.x;
    }

    public void Movement(float input)
    {
        rd.velocity = new Vector2(speed * input, 0);
    }
}
