using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float walkSpeed = 10f;
    float jumpForce = 30f;

    Rigidbody rb;
    Camera camera;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = camera.transform.forward;
        forward.y = 0;

        Vector3 right = camera.transform.right;
        right.y = 0;

        if (Input.GetKey("up"))
        {
            transform.Translate(forward * Time.deltaTime * walkSpeed);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(-1*forward * Time.deltaTime * walkSpeed);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(right * Time.deltaTime * walkSpeed);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(-1*right * Time.deltaTime * walkSpeed);
        }
        
        if (Input.GetKey("space"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
    }
}
