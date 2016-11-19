using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeftOffScreenRestart : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject EndGameScreen;
    public GameObject pause;
    float timeUpText = 5;
    public Text text;
    public Text starCount;
    public int timeUpFont = 150;
    public GameObject player;

    public IEnumerator IGameOverText()
    {
        text.enabled = false;
        pause.SetActive(false);
        starCount.enabled = false;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont * Time.deltaTime);
        //SceneManager.LoadScene("Splash Screen");
        EndGameScreen.SetActive(true);
        player.SetActive(false);
    }

    void Start()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 50));
    }

    void OnTriggerEnter()
    {
        //Statics.nextPosition = Statics.originalPosition;
        //Statics.backgroundNextPosition = Statics.backgroundOriginalPosition;
        //SceneManager.LoadScene("Prototype One");
        StartCoroutine(IGameOverText());
    }
}
