using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis ("Vertical");
        // Make vehicle move forward
        transform.Translate (Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Make vehicle turn
        transform.Rotate (Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
