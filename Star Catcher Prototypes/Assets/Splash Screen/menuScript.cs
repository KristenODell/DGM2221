using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public Canvas instructionsMenu;
    public Button startText;
    public Button instructionsButton;
    
	void Start ()
    {
        instructionsMenu = instructionsMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        instructionsButton = instructionsButton.GetComponent<Button>();
        instructionsMenu.enabled = false;
	}
	
	public void ExitPress ()
    {
        instructionsMenu.enabled = true;
        startText.enabled = false;
        instructionsButton.enabled = false;
    }

    public void PressExitInstructions ()
    {
        instructionsMenu.enabled = false;
        startText.enabled = true;
        instructionsButton.enabled = true;
    }
    public void StartLevel ()
    {
        SceneManager.LoadScene("Prototype One");
    }

}
