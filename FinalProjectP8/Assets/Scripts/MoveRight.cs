using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private GameManager gamemanager;
    private PlayerControl playerCS;
    private float rightBound = -2000;
    private float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        playerCS = GameObject.Find("Player").GetComponent<PlayerControl>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (playerCS.gameOver == false)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (transform.position.x < rightBound && !gameObject.CompareTag("Background"))
            {
                Destroy(gameObject);
            }
        }
    }

}
