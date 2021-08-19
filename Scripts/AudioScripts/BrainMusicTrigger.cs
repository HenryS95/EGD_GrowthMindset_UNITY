using UnityEngine;
using System.Collections;

public class BrainMusicTrigger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine("FadeIn");
    }


    public void OnTriggerExit(Collider other)
    {
        StartCoroutine("FadeOut");
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


    IEnumerator FadeIn()
    {
        source.Play();
        while (source.volume < 0.99f)
        {
            source.volume += Time.deltaTime / 2.0f;
            yield return null;
        }
        source.volume = 1;
        source.clip = clip;
        source.loop = true;

    }
}
