using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    public void PlayGame()
    {
        StartCoroutine("FadeOut");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    IEnumerator FadeOut()
    {
        while (source.volume > 0.01f)
        {
            source.volume -= Time.deltaTime / 2.0f;
            yield return null;
        }
        source.volume = 0;
        source.Pause();
    }


}
