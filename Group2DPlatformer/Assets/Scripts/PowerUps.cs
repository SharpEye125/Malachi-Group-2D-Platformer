using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public Transform bounceProjectile;
    public float bounceSpeed = 3f;
    public float bounceHeight = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BounceProjectile()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Ground")
        {

        }
    }
}
