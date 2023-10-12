using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = 15;
    [SerializeField] TextMeshProUGUI myText;
    int maxHealth = 15;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            myText.text = "health: " + health;
        }

        if (collision.gameObject.tag == "HealthPack" && health < maxHealth)
        {
            health += 7;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
            myText.text = "Health: " + health;
            Destroy(collision.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            myText.text = "Health: " + health;
        }


    }
}
    