using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameOver GMOver;
    public int health = 1;
    private GameManager gameManager;
    private Rigidbody playerRig;
    public float jumpForce;
    public float gravityModifier;
    public float speed = 3;
    public bool gameOver = false;
    private float forwardInput;
    public int maxPlatform = 0;
    // Start is called before the first frame update

    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {

            playerRig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            GMOver.setup(health);
            gameOver = true;
            Debug.Log(" HAHA LOSER!");
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Background"))
        {
            GMOver.setup(health);
            gameOver = true;
            Debug.Log(" WOW YOU'RE SO SMART");
        }
    }

}
