using UnityEngine;
using System.Collections;

public class BlackHoleNoise : MonoBehaviour
{
    private AudioSource source;
    public AudioClip blackHoleNoise;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        source.PlayOneShot(blackHoleNoise);
    }
}
