using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    IEnumerator MaxBoost()
    {
        BoosterLimitMax = true;
        yield return new WaitForSeconds(5);
        BoosterLimitMax = false;
    }

    GameObject Speeed;
    GameObject Gamee;
    GameObject Jumpp;
    GameObject Slow;
    public bool BoosterLimitMax = false;
    // Start is called before the first frame update
    void Start()
    {
        Speeed = GameObject.FindGameObjectWithTag("Speed");
        Gamee = GameObject.FindGameObjectWithTag("GameController");
        Jumpp = GameObject.FindGameObjectWithTag("Jump");
        Slow = GameObject.FindGameObjectWithTag("Slow");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Speed")
        {
            if (BoosterLimitMax == false) 
            {
                Speeed.GetComponent<Booster>().Dead = true;
                Gamee.GetComponent<Game>().CollPlayerSpeed = true;
                StartCoroutine(MaxBoost());
            }
        }
        if (collision.gameObject.tag == "Jump")
        {
            if (BoosterLimitMax == false) 
            {
                Jumpp.GetComponent<BoosterJump>().Dead = true;
                Gamee.GetComponent<Game>().CollPlayerJump = true;
                StartCoroutine(MaxBoost());
            }
        }
        if (collision.gameObject.tag == "Slow")
        {
            if (BoosterLimitMax == false)
            {
                Slow.GetComponent<Slow>().Dead = true;
                Gamee.GetComponent<Game>().CollPlayerSlow = true;
                StartCoroutine(MaxBoost());
            }
        }
    }
}
