//prawidłowe poruszanie się wraz z rotacją oraz skakanie, jeszcze bez animacji

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private float gravity = 9.81f;
    private float movementSpeed = 5f;
    private float jumpSpeed = 3.5f;
    private CharacterController _controller;
    Rigidbody rb;
    private float directionY;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (_controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                directionY = jumpSpeed;
            }
        }

        if(direction != Vector3.zero)
        {
            transform.forward = direction;
        }

        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        _controller.Move(direction * movementSpeed * Time.deltaTime);
    }
}
