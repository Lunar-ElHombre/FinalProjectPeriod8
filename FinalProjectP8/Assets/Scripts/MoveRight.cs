using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private float rightBound = -15;
    private float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x < rightBound && gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
        }
    }
  
}
