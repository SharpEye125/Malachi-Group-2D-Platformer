﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 5f;
    public float bounceHeight = 1f;
    public int damage = 1;
    public float gravity;
    public float gravityMultiplier;
    Rigidbody2D rb;
    //public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        gravity = rb.gravityScale;
        rb.gravityScale = gravity * 2;
        //rb = GetComponent<Rigidbody2D>();
        //velocity = rb.velocity;
    } 

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal == new Vector2(1,0) || collision.contacts[0].normal == new Vector2(-1, 0))
        {
            Destroy(gameObject);
        }
            GetComponent<Rigidbody2D>().AddForce
        (new Vector2(0, 100 * bounceHeight));
        rb.gravityScale = gravity;
        
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
