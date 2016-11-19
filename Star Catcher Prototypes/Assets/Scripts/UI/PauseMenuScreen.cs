using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuScreen : MonoBehaviour
{
    public Canvas instructionsMenu;

    // Use this for initialization
    void Start ()
    {
        instructionsMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void Quit ()
    {
        Application.Quit();
        print("Quit");
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("Splash Screen");
    }

    public void Instructions ()
    {
        instructionsMenu.enabled = true;
    }

    public void ExitInstructions ()
    {
        instructionsMenu.enabled = false;
    }
}
