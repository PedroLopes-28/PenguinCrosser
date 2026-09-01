using UnityEngine;

public class OrcaController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;

   private float speed = 1.5f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = _sprite = GetComponentInChildren<SpriteRenderer>();

        if (transform.position.x < 0)
        {
           
            _rb.AddForceX(speed, ForceMode2D.Impulse);
            _sprite.flipX = false;
        }
        else
        {
            
            _rb.AddForceX(-speed, ForceMode2D.Impulse);
            _sprite.flipX = true;
        }
    }
}