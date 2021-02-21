using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAstro : MonoBehaviour
    
{
    public GameObject Astro;
    public GameObject Chuj;
    public Transform Spawn;
    public bool StealLife = true;

    IEnumerator Death()
    {
        SpawnAstro();
        yield return new WaitForSeconds(5);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (StealLife == false)
        {
            StartCoroutine(Death());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Car3")
        {
            StealLife = false;
            Destroy(gameObject);
        }
    }
    void SpawnAstro()
    {
        Instantiate(Astro, Spawn.position, Quaternion.identity);
    }

}
