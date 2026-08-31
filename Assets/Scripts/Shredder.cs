using System;
using UnityEngine;

public class Shredder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.transform.parent.gameObject);
    }
}
