using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float jumpPower = 3f;
    public float movePower = 10f;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(Input.GetAxis("Horizontal")* movePower, 0, Input.GetAxis("Vertical") * movePower);
    }
}

