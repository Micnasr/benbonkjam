using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    [Header("Characteristics")]
    public float health;

    void Update()
    {
        if (health <= 0)
        {
            Die();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        print("reload");
        if (collision.tag == "EnemyBullet")
        {
            health -= 1;
        }
    }
    
    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
