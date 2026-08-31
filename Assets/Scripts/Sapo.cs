using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sapo : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float speed;
    private Vector2 movimento;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();//pega o rigid body para usar na hora de fazer movimento

    }
    
    void OnMove(InputValue inputValue)
    {
        movimento = inputValue.Get<Vector2>();
    }

    void Movimentar()
    {
        _rb.linearVelocity = movimento * speed;
        
    }



    // Update is called once per frame
    void Update()
    {
        Movimentar();
    }
}
