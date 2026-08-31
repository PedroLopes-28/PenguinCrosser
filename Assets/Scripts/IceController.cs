using UnityEngine;

public class IceController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;

    [SerializeField] private float speed = 2.5f;

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