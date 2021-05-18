using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggermove : MonoBehaviour
{

    public Rigidbody rb;
    public Rigidbody rb2;
    public Rigidbody rb3;
    void Start()
    {
        rb.useGravity = false;
        rb2.useGravity = false;
        rb3.useGravity = false;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            rb.useGravity = true;
            rb2.useGravity = true;
            rb3.useGravity = true;
        }
    }
}
