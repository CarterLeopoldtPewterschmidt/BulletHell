using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int enemyHealth = 10;





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Throwable") 
        {
            enemyHealth--;


        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player Throwable")
        {
            enemyHealth--;


        }



    }






    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
