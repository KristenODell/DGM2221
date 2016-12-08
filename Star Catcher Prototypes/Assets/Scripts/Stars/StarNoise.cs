using UnityEngine;
using System.Collections;

public class StarNoise : MonoBehaviour
{
    private AudioSource source;
    public AudioClip collectingNoise;

    // Use this for initialization
    void Start ()
    {
        source = GetComponent<AudioSource>();
    }
	
    void OnCollisionEnter()
    {
        source.PlayOneShot(collectingNoise);
    }
}
