using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text text;
    float timeRemaining = 125;
    float timeUpText = 5;
    public int timeUpFont = 5;
    public GameObject gameOverText;

    public IEnumerator IGameOverText()
    {
        text.text = null;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont);
        SceneManager.LoadScene("Splash Screen");
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
                //text.text = "TIME'S UP!";
                //text.fontSize = timeUpFont;
                //yield return new WaitForSeconds(timeUpText);
                //SceneManager.LoadScene("Splash Screen");
            }
        }
    }
}
