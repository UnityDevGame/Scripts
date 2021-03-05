using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAstro : MonoBehaviour
    
{
    public GameObject Astro;
    public GameObject Chuj;
    public Transform Spawn;
    public bool StealLife = true;
    public int zyje;


    IEnumerator Death()
    {
        yield return new WaitForSeconds(5);
        zyje = 2;
        yield return new WaitForSeconds(5);
        zyje = 0;
    }
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()

    {
     
        if (zyje == 1)
        {
            StartCoroutine(Death());
        }
        if (zyje == 2)
        {
            SpawnAstro();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Car3")
        {
            zyje = 1;
            Destroy(gameObject);
        }
    }
    void SpawnAstro()
    {
        Instantiate(Astro, Spawn.position, Quaternion.identity);
    }
    
}
