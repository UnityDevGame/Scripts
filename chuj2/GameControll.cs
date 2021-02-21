using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControll : MonoBehaviour
{
    public GameObject Astro;
    public Transform Spawn;


    // Start is called before the first frame update
    void Start()
    {
        SpawnAstro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAstro()
    {
        Instantiate(Astro, Spawn.position, Quaternion.identity);
    }
}
