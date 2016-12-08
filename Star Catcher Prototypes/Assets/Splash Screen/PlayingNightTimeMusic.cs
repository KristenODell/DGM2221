using UnityEngine;
using System.Collections;

public class PlayingNightTimeMusic : MonoBehaviour
{

    private AudioSource source;
    public AudioClip backgroundMusic;

    public IEnumerator FadeMusic ()
    {
        while (source.volume < 1f)
        {
            yield return new WaitForSeconds(.5f);
            source.volume += .06f;

        }
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(backgroundMusic, .01f);
        StartBackgroundMusic();
    }

    void StartBackgroundMusic()
    {
        StartCoroutine(FadeMusic());
    }
}
