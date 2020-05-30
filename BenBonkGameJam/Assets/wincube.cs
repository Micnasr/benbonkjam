using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wincube : MonoBehaviour
{
    public Animator animator;

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(GoToNextLevel());
    }
    

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");

    }

    IEnumerator GoToNextLevel()
    {
        FadeToLevel();
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
