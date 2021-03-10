using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    GameObject Speeed;
    GameObject Gamee;
    // Start is called before the first frame update
    void Start()
    {
        Speeed = GameObject.FindGameObjectWithTag("Speed");
        Gamee = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Speed")
        {
            Speeed.GetComponent<Booster>().Dead = true;
            Gamee.GetComponent<Game>().CollPlayer = true;

        }
    }
}
