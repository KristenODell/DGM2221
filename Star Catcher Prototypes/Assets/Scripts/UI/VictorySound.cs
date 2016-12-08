using UnityEngine;
using System.Collections;

public class VictorySound : MonoBehaviour {


    private AudioSource victorySource;
    public AudioClip victory;
    public CountDownTimer timer;

    // Use this for initialization
    void Start ()
    {
        victorySource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(timer.timeRemaining <= 0)
        {
            victorySource.PlayOneShot(victory);
        }
	}
}
