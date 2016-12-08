using UnityEngine;
using System.Collections;

public class GameOverSound : MonoBehaviour
{
    private AudioSource gameOverSource;
    public AudioClip gameOver;

	void Start ()
    {
        gameOverSource = GetComponent<AudioSource>();
	}

    void OnTriggerEnter()
    {
        gameOverSource.PlayOneShot(gameOver);
    }
	
}
