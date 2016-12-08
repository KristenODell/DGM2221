using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuScreen : MonoBehaviour
{
    public Canvas instructionsMenu;

    private AudioSource buttonClickSource;
    public AudioClip buttonClick;

    // Use this for initialization
    void Start ()
    {
        instructionsMenu.enabled = false;
        buttonClickSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Quit ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        Application.Quit();
        print("Quit");
    }

    public void MainMenu ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        SceneManager.LoadScene("Splash Screen");
    }

    public void Instructions ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        instructionsMenu.enabled = true;
    }

    public void ExitInstructions ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        instructionsMenu.enabled = false;
    }
}
