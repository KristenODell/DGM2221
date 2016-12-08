using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public Canvas instructionsMenu;
    public Button startText;
    public Button instructionsButton;

    private AudioSource buttonClickSource;
    public AudioClip buttonClick;

    void Start ()
    {
        instructionsMenu = instructionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        instructionsButton = instructionsButton.GetComponent<Button>();
        instructionsMenu.enabled = false;
        buttonClickSource = GetComponent<AudioSource>();
    }
	
	public void ExitPress ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        instructionsMenu.enabled = true;
        startText.enabled = false;
        instructionsButton.enabled = false;
    }

    public void PressExitInstructions ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        instructionsMenu.enabled = false;
        startText.enabled = true;
        instructionsButton.enabled = true;
    }
    public void StartLevel ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        Statics.nextPosition = Statics.originalPosition;
        Statics.backgroundNextPosition = Statics.backgroundOriginalPosition;
        SceneManager.LoadScene("Prototype One");
    }

}
