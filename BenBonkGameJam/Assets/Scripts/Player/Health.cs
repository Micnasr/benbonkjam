using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject deathEffect;
    public GameObject playerModel;

    bool on = false;

    [Header("Characteristics")]
    public float health;

    void Update()
    {
        if (health <= 0)
        {

            if (!on)
            {
                Instantiate(deathEffect, transform.position, Quaternion.Euler(-90, 0, 0));
                FindObjectOfType<audiomanager>().Play("DeathSound");
                on = true;
            }
            playerModel.SetActive(false);
            StartCoroutine(Die());
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            health -= 1;
        }
    }
    
    IEnumerator Die()
    {
        
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
