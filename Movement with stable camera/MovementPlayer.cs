using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    CharacterController _controller;
    public float movementSpeed = 15f;
    //You must set very small value of gravity and jumpHeight
    public float gravity = -1f;
    public float jumpheight = 0.08f;
    public Vector3 movePlayer;
    public float movePlayerY;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimationController.SetBool("playMove", false);
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        movePlayer = (move * movementSpeed * Time.deltaTime);

        if (move != Vector3.zero)
        {
            transform.forward = move;
        }

        if (_controller.isGrounded && movePlayerY < 0)
        {
            movePlayerY = 0f;
        }

        if (_controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                myAnimationController.SetBool("playMove", true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                myAnimationController.SetBool("playMove", true);
            }
            if (Input.GetKey(KeyCode.S))
            {
                myAnimationController.SetBool("playMove", true);
            }
            if (Input.GetKey(KeyCode.D))
            {
                myAnimationController.SetBool("playMove", true);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movePlayerY += Mathf.Sqrt(jumpheight);
                myAnimationController.SetBool("playJump", true);
            }
            else
            {
                myAnimationController.SetBool("playJump", false);
            }
        }
        movePlayerY += gravity * Time.deltaTime;
        movePlayer.y = movePlayerY;
        _controller.Move(movePlayer);
    }
}
