using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndGameScreen : MonoBehaviour
{
    public Button playAgainButton;
    public Button mainMenuButton;
    public Button quitGameButton;

    // Use this for initialization
    void Start ()
    {
        playAgainButton = playAgainButton.GetComponent<Button>();
        mainMenuButton = mainMenuButton.GetComponent<Button>();
        quitGameButton = quitGameButton.GetComponent<Button>();
    }
	
    public void ExitGame ()
    {
        print("Quit");
        Application.Quit();
    }

    public void PlayAgain()
    {
        Statics.nextPosition = Statics.originalPosition;
        Statics.backgroundNextPosition = Statics.backgroundOriginalPosition;
        SceneManager.LoadScene("Prototype One");
    }
    
    public void MainMenu ()
    {
        SceneManager.LoadScene("Splash Screen");
    }

   
}
