using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    GameObject Speed;
    GameObject Jumpik;
    GameObject Slowek;
    IEnumerator Speedek()
    {
        Speed.GetComponent<MovementPlayer>().movementSpeed = 25f;
        CollPlayerSpeed = false;
        yield return new WaitForSeconds(5);
        Speed.GetComponent<MovementPlayer>().movementSpeed = 15f;
    }
    IEnumerator Slow()
    {
        Slowek.GetComponent<MovementPlayer>().movementSpeed = 7f;
        CollPlayerSlow = false;
        yield return new WaitForSeconds(5);
        Slowek.GetComponent<MovementPlayer>().movementSpeed = 15;
    }
    IEnumerator Jump()
    {
        Jumpik.GetComponent<MovementPlayer>().jumpheight = 0.10f;
        CollPlayerJump = false;
        yield return new WaitForSeconds(5);
        Jumpik.GetComponent<MovementPlayer>().jumpheight = 0.05f;
    }

    public bool CollPlayerSpeed = false;
    public bool CollPlayerJump = false;
    public bool CollPlayerSlow = false;
    // Start is called before the first frame update
    void Start()
    {
        Speed = GameObject.FindGameObjectWithTag("Player");
        Jumpik = GameObject.FindGameObjectWithTag("Player");
        Slowek = GameObject.FindGameObjectWithTag("Player");
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
