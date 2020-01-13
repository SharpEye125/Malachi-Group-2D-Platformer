using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public int powerUp;
    public float timer = 0f;
    public float powerUpTimer = 10f;
    public bool hasPowerUp = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPowerUp == true)
        {
            timer += Time.deltaTime;
            if (timer > powerUpTimer)
                {
                    hasPowerUp = false;
                    powerUp = 0;
                    timer = 0;
                    UpdatePowerUps();
                }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("PowerUp1"))
        {
            powerUp = 1;
            hasPowerUp = true;
            timer = 0;
        }

        if (collision.tag == ("PowerUp2"))
        {
            powerUp = 2;
            hasPowerUp = true;
            timer = 0;
        }

        if (collision.tag == ("PowerUp3"))
        {
            powerUp = 3;
            hasPowerUp = true;
            timer = 0;
        }

        UpdatePowerUps();
    }

    void UpdatePowerUps()
    {
        GetComponent<ShootingScript>().powerUps = powerUp;
    }
}
