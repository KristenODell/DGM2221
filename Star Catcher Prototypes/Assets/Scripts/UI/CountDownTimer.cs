using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text text;
    public Text starCount;
    public Text stealthCount;
    float timeRemaining = 125;
    public int timeUpFont = 150;
    public GameObject gameOverText;
    public GameObject EndGameScreen;
    public GameObject player;
    public GameObject pause;
    public GameObject starScreen;
    public AudioSource backgroundMusic;

    public IEnumerator IGameOverText()
    { 
        player.SetActive(false);
        text.enabled = false;
        pause.SetActive(false);
        starScreen.SetActive(false);
        starCount.enabled = false;
        stealthCount.enabled = false;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont * Time.deltaTime);
        backgroundMusic.volume = .07f;
        EndGameScreen.SetActive(true);
    }


	void Start ()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        if (!GameManager.Instance.Paused)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining >= 0)
            {
                text.text = "TIME REMAINING: " + timeRemaining.ToString("f0");
            }
            else
            {
                StartCoroutine(IGameOverText());
            }
        }
    }
}
