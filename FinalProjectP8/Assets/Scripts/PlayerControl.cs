using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRig;
    public float jumpForce;
    public float gravityModifier;
    public float speed = 3;
    private float forwardInput;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
