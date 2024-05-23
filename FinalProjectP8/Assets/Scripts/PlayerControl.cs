using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRig;
    public float jumpForce;
    public float gravityModifier;
    private float speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
