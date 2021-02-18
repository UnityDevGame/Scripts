using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    public float jumpHeight; //set it to ~ 600
    public bool isGrounded;
    public float gravityStrenght; //set it to ~ -60

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 gravity5 = new Vector3(0, gravityStrenght, 0);

        Physics.gravity = gravity5;
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            jump();
        }
    }

    void jump()
    {
        rb.AddForce(new Vector3(0, jumpHeight, 0));
        isGrounded = false;
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
