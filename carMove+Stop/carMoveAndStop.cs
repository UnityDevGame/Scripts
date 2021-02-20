using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMoveAndStop : MonoBehaviour
{
    public float gravityStr;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 gravity5 = new Vector3(0, gravityStr, 0);
        Physics.gravity = gravity5;
    }

    public int ms = 15;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.left * ms;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        ms = 15;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Stop")
        {
            ms = 0;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        StartCoroutine(wait());
    }
}
