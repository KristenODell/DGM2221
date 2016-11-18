using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenuScreen : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
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
}
