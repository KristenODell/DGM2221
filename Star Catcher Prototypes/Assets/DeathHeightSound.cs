using UnityEngine;
using System.Collections;

public class DeathHeightSound : MonoBehaviour
{

    private AudioSource dyingSource;
    public AudioClip dying;
    public GameObject player;

    public float deathHeight = -100f;

    // Use this for initialization
    void Start ()
    {
        dyingSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (player.transform.position.y <= deathHeight)
        {
            print("I'm dying");
            dyingSource.PlayOneShot(dying);
        }
    }
}
