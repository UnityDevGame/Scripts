using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    GameObject obj;
    public GameObject Astro;
    public Transform Spawn;
    public bool MaBombe = false;
    IEnumerator Death()
    {
        yield return new WaitForSeconds(15);
        SpawnAstro();
        MaBombe = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (MaBombe == true)
        {
            obj.GetComponent<Dead>().zyje = false;
            StartCoroutine(Death());
        }
        
    }
    void SpawnAstro()
    {
        Instantiate(Astro, Spawn.position, Quaternion.identity);
    }

}
