using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Rigidbody rb;
    public float xInput;
    public float zInput;

    public float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float xVelocity = xInput * moveSpeed;
        float zVelocity = zInput * moveSpeed;

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);
    }
}
