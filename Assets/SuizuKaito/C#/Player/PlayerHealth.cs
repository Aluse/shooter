using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 3;
    public int currentHealth;
    public float timer = 0.0f;
    bool isDead;
    
    public bool invincible;
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
            Death();
        }
        if (invincible && timer <= 3.0f)
        {
            timer += 0.1f;
            if (timer >= 3.0f)
            {
                invincible = false;
            }
        }
    }
    void Death()
    {
        isDead = true;
        SceneManager.LoadScene("GameOver");

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Enemy") || collision.gameObject.tag == ("EnemyBullet"))
        {
            if (!invincible)
            {
                currentHealth -= 1;
                PlayerManager.Rm = currentHealth;
            }
        }
        if (collision.gameObject.tag == ("AItem2"))
        {
            invincible=true;
            timer = 0.0f;
        }
    }
}


