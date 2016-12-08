using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameScreen : MonoBehaviour
{
    public Button playAgainButton;
    public Button mainMenuButton;
    public Button quitGameButton;

    private AudioSource buttonClickSource;
    public AudioClip buttonClick;

    // Use this for initialization
    void Start ()
    {
        buttonClickSource = GetComponent<AudioSource>();
        playAgainButton = playAgainButton.GetComponent<Button>();
        mainMenuButton = mainMenuButton.GetComponent<Button>();
        quitGameButton = quitGameButton.GetComponent<Button>();
    }
	
    public void ExitGame ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        print("Quit");
        Application.Quit();
    }

    public void PlayAgain()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        Statics.nextPosition = Statics.originalPosition;
        Statics.backgroundNextPosition = Statics.backgroundOriginalPosition;
        SceneManager.LoadScene("Prototype One");
    }
    
    public void MainMenu ()
    {
        buttonClickSource.PlayOneShot(buttonClick);
        SceneManager.LoadScene("Splash Screen");
    }

   
}
