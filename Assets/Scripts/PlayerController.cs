using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private float speed = 100.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the car forward based on vertical input
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        // Rotates the based on horizontal input
        transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * Vector3.up);
    }
}
