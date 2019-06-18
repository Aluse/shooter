using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    public int startingHealth = 3;
    public int currentHealth;
    bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0 && !isDead)
        {
            Destroy(gameObject);
        }
    }
    void Death()
    {
        isDead = true;
        Destroy(gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Enemy") || collision.gameObject.tag == ("EnemyBullet"))
        {
            currentHealth -= 1;
        }
    }
}

