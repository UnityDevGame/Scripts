using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawn : MonoBehaviour
{
    //drag bomb from assets for bomb and spawn position for bombSpawnPosition

    public GameObject bomb;
    private GameObject bombB;
    private GameObject[] players;
    private GameObject randomPlayer;
    private Transform deadPlayer;
    private bool detonateBomb = false;
    public Transform bombSpawnPosition;
    private GameObject manager;
    public int timeToDetonate;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("spawn");
        bombB = Instantiate(bomb, bombSpawnPosition.position, Quaternion.identity);
        players = GameObject.FindGameObjectsWithTag("Player");
        randomPlayer = players[Random.Range(0, players.Length)];
        bombB.transform.parent = randomPlayer.transform;
        bombB.transform.position = randomPlayer.transform.position + new Vector3(0f, 2f, 3f);
        StartCoroutine(detonate());
    }

    // Update is called once per frame
    void Update()
    {
        if(detonateBomb == true)
        {
            spawn();
            players = GameObject.FindGameObjectsWithTag("Player");
            randomPlayer = players[Random.Range(0, players.Length)];
            bombB.transform.parent = randomPlayer.transform;
            bombB.transform.position = randomPlayer.transform.position + new Vector3(0f, 2f, 3f);
            StartCoroutine(detonate());
            detonateBomb = false;
            Debug.Log(players.Length);
        }
        if(players.Length-1 == 0)
        {
            Destroy(bombB);
            manager.SetActive(false);
        }
    }

    IEnumerator detonate()
    {
        deadPlayer = bombB.transform.root;
        yield return new WaitForSeconds(timeToDetonate);
        Destroy(deadPlayer.gameObject);
        detonateBomb = true;
    }

    void spawn()
    {
        bombB = Instantiate(bomb, bombSpawnPosition.position, Quaternion.identity);
    }
}
