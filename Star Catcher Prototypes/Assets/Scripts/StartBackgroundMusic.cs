using UnityEngine;
using System.Collections;

public class StartBackgroundMusic : MonoBehaviour
{

    private AudioSource source;
    public AudioClip backgroundMusic;

	void Start ()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(backgroundMusic, .2f);
	}
	
}
