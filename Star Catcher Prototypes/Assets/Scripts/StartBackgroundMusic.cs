using UnityEngine;
using System.Collections;

public class StartBackgroundMusic : MonoBehaviour
{
    public CountDownTimer timer;
    private AudioSource source;
    public AudioClip backgroundMusic;

	void Start ()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(backgroundMusic);
	}

    void Update ()
    {
        if(timer.timeRemaining <= 105)
        {
            source.volume = .03f;
        }
    }
	
}
