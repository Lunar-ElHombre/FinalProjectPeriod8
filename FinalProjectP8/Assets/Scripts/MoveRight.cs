using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private PlayerControl playerCS;
    private float rightBound = -77;
    private float speed = 8;
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
            if (playerCS.doubleSpeed)
            {
                transform.Translate(Vector3.right * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.right * Time.DeltaTime * speed);
            }


            if (transform.position.x < rightBound && gameObject.CompareTag("Asteroid"))
            {
                Destroy(gameObject);
            }
        }
    }
  
}
