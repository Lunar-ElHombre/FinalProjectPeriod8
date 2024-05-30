using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerControl playerCS;
    public GameObject asteriodPrefabs;
    private Vector3 spawnPos = new Vector3(1553, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 3;
    public float Height = 1;
    public float Speed = 1;
    private float Ypos;

    // Start is called before the first frame update
    void Start()
    {
      
        InvokeRepeating("SpawnAsteroid", startDelay, repeatRate);
        playerCS = GameObject.Find("Player").GetComponent<PlayerControl>();
        Ypos = transform.position.y;
    }

    // Update is called once per frame
     void Update()
    {
        
    }
    void SpawnAsteroid()
    {
            Vector3 spawnPos = transform.position;
            if (playerCS.gameOver == false)
            {
                Instantiate(asteriodPrefabs, spawnPos, asteriodPrefabs.transform.rotation);
            }
        
    }
}
