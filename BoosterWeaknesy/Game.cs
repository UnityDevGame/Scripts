using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    GameObject Speed;
    GameObject Jumpik;
    IEnumerator Speedek()
    {
        Speed.GetComponent<playerMove>().movementSpeed = 8;
        CollPlayerSpeed = false;
        yield return new WaitForSeconds(5);
        Speed.GetComponent<playerMove>().movementSpeed = 4;
    }
    IEnumerator Slow()
    {
        Speed.GetComponent<playerMove>().movementSpeed = 2;
        CollPlayerSpeed = false;
        yield return new WaitForSeconds(5);
        Speed.GetComponent<playerMove>().movementSpeed = 4;
    }
    IEnumerator Jump()
    {
        Jumpik.GetComponent<playerMove>().gravity = 5;
        CollPlayerJump = false;
        yield return new WaitForSeconds(5);
        Jumpik.GetComponent<playerMove>().gravity = 10;
    }

    public bool CollPlayerSpeed = false;
    public bool CollPlayerJump = false;
    public bool CollPlayerSlow = false;
    // Start is called before the first frame update
    void Start()
    {
        Speed = GameObject.FindGameObjectWithTag("Player");
        Jumpik = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (CollPlayerSpeed == true)
        {
            StartCoroutine(Speedek());
        }
        if (CollPlayerJump == true)
        {
            StartCoroutine(Jump());
        }
        if (CollPlayerSlow == true)
        {
            StartCoroutine(Slow());
        }
    }

}
