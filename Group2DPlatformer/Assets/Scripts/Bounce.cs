using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 1;
    public Rigidbody2D rb;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = rb.velocity;
    } 

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < velocity.y)
        {
            rb.velocity = velocity;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = new Vector2 (velocity.x, - velocity.y);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

    }
}
