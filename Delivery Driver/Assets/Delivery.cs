using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float packageDestroyTimer = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kachow");
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, packageDestroyTimer);
        }
        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
