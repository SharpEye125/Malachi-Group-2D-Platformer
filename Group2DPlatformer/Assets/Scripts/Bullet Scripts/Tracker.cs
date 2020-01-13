using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{

    public float speed = 5f;
    public int damage = 1;
    public float chaseDistance = 50f;
    public Transform nearestEnemy;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        

        nearestEnemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        



        
        Chase();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

    //If I have the time later I will try an A* approach
    void Chase()
    {
        Vector2 chaseDirection = new Vector2(nearestEnemy.position.x - transform.position.x,
            nearestEnemy.position.y - transform.position.y);
        chaseDirection.Normalize();
        GetComponent<Rigidbody2D>().velocity = chaseDirection * speed;
    }
}
