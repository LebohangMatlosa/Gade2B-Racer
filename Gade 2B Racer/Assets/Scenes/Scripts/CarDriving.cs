using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 17;
    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    Vector3 TurnRight = new Vector3(0, 80, 0);
    Vector3 TurnLeft = new Vector3(0, -80, 0);

    void FixedUpdate()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(TurnRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(TurnLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}
