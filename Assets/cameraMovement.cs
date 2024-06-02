using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    float speedX = 2f;
    float speedY = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Mouse Y");
        float Y = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(X * speedX, Y * speedY, 0);
        transform.eulerAngles += rotation;
    }
}
