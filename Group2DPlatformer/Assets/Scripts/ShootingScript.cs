using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public GameObject bounce;
    public GameObject temp;

    [Range(0, 3)]
    public int powerUps = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        switch (powerUps)
        {
            case 1:
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                break;
            case 2:
                Instantiate(bounce, firePoint.position, firePoint.rotation);
                break;
            case 3:
                Instantiate(temp, firePoint.position, firePoint.rotation);
                break;
            default:

                break;
        }
        
    }
    //Use Input.GetAxisRaw
}
