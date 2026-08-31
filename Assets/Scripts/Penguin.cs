using UnityEngine;
using UnityEngine.InputSystem;

public class Penguin : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField] private float distancia = 1f;
    [SerializeField] private float walkSpeed = 0.3f;

    private float lastMove;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue inputValue)
    {
        Vector2 movimento = inputValue.Get<Vector2>();

        if (movimento == Vector2.zero)
            return;

        if (Time.time >= lastMove + walkSpeed)
        {
            _rb.MovePosition(
                _rb.position + new Vector2(0, movimento.y * distancia)
            );

            lastMove = Time.time;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Obstacle")){
            FindObjectOfType<GameOverManager>().GameOver();
        }
    }
}