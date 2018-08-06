using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Dash Script up and running!");
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        { 
            rb.AddForce(transform.forward * thrust);
            print("R key was pressed");
        }
    }
}
