using UnityEngine;
using System.Collections;

public class WolfHowl : MonoBehaviour {

    private AudioSource wolfHowlSource;
    public AudioClip wolfHowl;

    void Start()
    {
        wolfHowlSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter ()
    {
        if (!wolfHowlSource.isPlaying)
        {
            wolfHowlSource.PlayOneShot(wolfHowl);
        }
    }
}
