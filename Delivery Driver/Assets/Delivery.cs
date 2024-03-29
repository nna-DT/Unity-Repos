using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kachow");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }
}