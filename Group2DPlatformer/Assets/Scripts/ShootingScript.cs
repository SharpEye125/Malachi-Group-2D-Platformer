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

    //GetAxisRaw if value /= 0 then multiply projectile value by velocity when spawned

    // Update is called once per frame
    void Update()
    {
        float fireX = Input.GetAxisRaw("Horizontal");
        if (fireX != 0)
        {

        }
            if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        float fireX = Input.GetAxisRaw("Horizontal");
        switch (powerUps)
        {
            case 1:
                Instantiate(bullet, firePoint.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(bounce, firePoint.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(temp, firePoint.position, Quaternion.identity);
                break;
            default:

                break;
        }
        
    }
    //Use Input.GetAxisRaw
}
