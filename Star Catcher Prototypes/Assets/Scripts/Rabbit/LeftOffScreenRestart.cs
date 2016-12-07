using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeftOffScreenRestart : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject EndGameScreen;
    public GameObject pause;
    public GameObject star;
    public Text text;
    public Text starCount;
    public Text stealthCount;
    public int timeUpFont = 150;
    public GameObject player;
    public int wait = 30;
    public AudioSource backgroundMusic;

    public IEnumerator IGameOverText()
    {
        player.SetActive(false);
        star.SetActive(false);
        text.enabled = false;
        pause.SetActive(false);
        starCount.enabled = false;
        stealthCount.enabled = false;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont * Time.deltaTime);
        backgroundMusic.volume = .07f;
        EndGameScreen.SetActive(true);

    }

    void OnTriggerEnter()
    {
        StartCoroutine(IGameOverText());
    }
}
