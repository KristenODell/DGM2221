using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetFinalScore : MonoBehaviour
{
    public Text finalScore;
    private StarCounter starCount;

	// Use this for initialization
	void Start ()
    {
        finalScore = GetComponent<Text>();
        starCount = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        finalScore.text = "FINAL SCORE : " + starCount.starCount;
        Time.timeScale = 0;
    }
}
