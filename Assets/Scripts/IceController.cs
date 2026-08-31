using System;
using System.Collections.Generic;
using UnityEngine;

public class IceController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float Speed = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        _rb=GetComponent<Rigidbody2D>();
        _rb.AddForceX(Speed, ForceMode2D.Impulse);
    }

  
}
