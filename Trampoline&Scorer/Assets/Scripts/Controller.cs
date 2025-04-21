using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float rotationSpeedX = 50f;
    public float rotationSpeedY = 50f;

    private void FixedUpdate()
    {
        // get component from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // calculate the rotation amount
        float rotationX = horizontalInput * rotationSpeedX * Time.captureDeltaTime;
        float rotationZ = verticalInput * rotationSpeedY * Time.captureDeltaTime;

        // rotate the game objectaround the x & z axis
        transform.Rotate(rotationX, 0f, rotationZ);
    }
 
}
