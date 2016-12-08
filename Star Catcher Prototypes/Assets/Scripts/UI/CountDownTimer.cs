using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text text;
    public Text starCount;
    public Text stealthCount;
    public float timeRemaining = 125;
    public int timeUpFont = 150;
    public GameObject gameOverText;
    public GameObject EndGameScreen;
    public GameObject player;
    public GameObject pause;
    public GameObject starScreen;
    public AudioSource backgroundMusic;
    public GameObject numberFlash;
    public GameObject particles;


    private AudioSource source;
    public AudioClip clip;

    int i = 1;

    public IEnumerator IGameOverText()
    {
        backgroundMusic.volume = .02f;
        player.SetActive(false);
        numberFlash.SetActive(false);
        particles.SetActive(false);
        text.enabled = false;
        pause.SetActive(false);
        starScreen.SetActive(false);
        starCount.enabled = false;
        stealthCount.enabled = false;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont * Time.deltaTime);
        EndGameScreen.SetActive(true);
    }


	void Start ()
    {
        text = GetComponent<Text>();
        source = GetComponent<AudioSource>();
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
                while (i > 0)
                {
                    if (!source.isPlaying)
                    {
                        source.PlayOneShot(clip);
                    }
                    i--;
                }
                StartCoroutine(IGameOverText());
            }
        }
    }
}
