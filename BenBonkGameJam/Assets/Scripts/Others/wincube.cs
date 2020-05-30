using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wincube : MonoBehaviour
{
    public Animator animator;
    public GameObject winEffect;

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(GoToNextLevel());
        FindObjectOfType<audiomanager>().Play("WinSound");
    }
    

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");

    }

    IEnumerator GoToNextLevel()
    {
        Instantiate(winEffect, transform.position, Quaternion.Euler(-90, 0, 0));
        yield return new WaitForSeconds(.8f);
        FadeToLevel();
        yield return new WaitForSeconds(1.2f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
