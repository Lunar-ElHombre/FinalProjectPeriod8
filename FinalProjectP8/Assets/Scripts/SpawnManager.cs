using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerControl playerCS;
    public GameObject asteriodPrefabs;
    private Vector3 spawnPos = new Vector3(1553, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 3;

    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnAsteroid", startDelay, repeatRate);
        playerCS = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnAsteroid ()
    {
        if (playerCS.gameOver == false)
        {
            Instantiate(asteriodPrefabs, spawnPos, asteriodPrefabs.transform.rotation);
        }
    }
}
