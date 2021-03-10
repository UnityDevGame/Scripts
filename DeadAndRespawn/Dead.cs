using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public int zycie = 2;
    public bool zyje = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zyje==false)
        {
            Destroy(gameObject);
        }
    }
}
