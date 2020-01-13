using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 5f;
    public float bounceHeight = 1f;
    public int damage = 1;
    public Rigidbody2D rb;
    public Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        


        //rb = GetComponent<Rigidbody2D>();
        //velocity = rb.velocity;
    } 

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        
    }
}
