using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageScript : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    SpriteRenderer spriteRenderer;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    } 

    private void Awake() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "DeliveryPackage" && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "CustomerPackage" && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;

        }
    }
}
