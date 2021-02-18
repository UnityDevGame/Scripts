using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public bool touch;
    public float gravityStr;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 gravity5 = new Vector3(0, gravityStr, 0);
        Physics.gravity = gravity5;
        StartCoroutine(wait());
    }

    public int ms = 15;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.left * ms;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stop")
        {
            ms = 0;
            touch = true;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        ms = 15;
        touch = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Stop")
        {
            StartCoroutine(wait());
        }
    }
}
