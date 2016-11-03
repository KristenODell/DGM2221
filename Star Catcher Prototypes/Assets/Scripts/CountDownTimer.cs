using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text text;
    float timeRemaining = 125;
    //float timeUpText = 5;
    public int timeUpFont = 20;

	void Start ()
    {
        text = GetComponent<Text>();
	}


    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            text.text = "TIME REMAINING: " + timeRemaining.ToString("f0");
        }
        else
        {
            text.text = "TIME'S UP!";
            text.fontSize = timeUpFont;
            //yield return new WaitForSeconds(timeUpText);
            SceneManager.LoadScene("Splash Screen");
        }
    }
}
