using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    public Text text;
    float timeRemaining = 125;
   // float timeUpText = 5;

	void Start ()
    {
        text = GetComponent<Text>();
	}
	
	void Update ()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            text.text = "TIME REMAINING: " + timeRemaining.ToString("f0");
        }
        else
        {
            text.text = "TIME'S UP!";
            //yield return new WaitForSeconds(timeUpText);
            Statics.nextPosition = Statics.originalPosition;
            SceneManager.LoadScene("Splash Screen");
        }
    }
}
