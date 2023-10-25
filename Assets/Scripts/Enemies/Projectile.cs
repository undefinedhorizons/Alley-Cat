using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    private float _life_time = 3f;
    private Rigidbody2D _rigidbody;
    private bool hasHitPlayer;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    public void ShootAt(Vector3 target_position)
    {
        gameObject.SetActive(true);
        Invoke("Deactivate", _life_time);

        Vector3 direction = target_position - transform.position;
        _rigidbody.velocity = new Vector2(direction.x, direction.y).normalized * _speed;
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
