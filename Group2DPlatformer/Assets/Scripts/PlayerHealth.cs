using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public int maxHealth;
    public Text healthText;
    public Slider healthSlider;
    public bool contact;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (contact == false)
            {
                StartCoroutine("LoseHealth");
            }
            contact = true;
            health--;
            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    //For continuous contact
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (gameObject.tag == "Enemy")
        {
            contact = true;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (gameObject.tag == "Enemy")
        {
            contact = false;
            StopCoroutine("LoseHealth");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Plus Health
        if (collision.gameObject.tag == "Health" && health < maxHealth)
        {
            health++;
            Destroy(collision.gameObject);
            UpdateHP();
        }
    }
    //Updates UI
    public void UpdateHP()
    {
        healthText.text = "Health:" + health;
        healthSlider.value = health;
    }

    IEnumerator LoseHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            health--;
        }

    }
}
