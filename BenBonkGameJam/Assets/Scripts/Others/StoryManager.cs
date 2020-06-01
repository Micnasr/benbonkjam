using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryManager : MonoBehaviour
{

    public GameObject Line1;
    public GameObject Line2;
    public GameObject Line3;

    public GameObject background;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        background.SetActive(true);
        Line1.SetActive(true);
        Line2.SetActive(false);
        Line3.SetActive(false);
        yield return new WaitForSeconds(6f);
        Line1.SetActive(false);
        Line2.SetActive(true);
        Line3.SetActive(false);
        yield return new WaitForSeconds(6f);
        Line1.SetActive(false);
        Line2.SetActive(false);
        Line3.SetActive(true);
        yield return new WaitForSeconds(6f);
        Line1.SetActive(false);
        Line2.SetActive(false);
        Line3.SetActive(false);
        background.SetActive(false);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
