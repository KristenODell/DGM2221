using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GetFinalScore : MonoBehaviour
{
    public Text finalScore;
    private StarCounter starCount;
    public Text level;

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
        if(starCount.starCount >= 0 && starCount.starCount < 15)
        {
            level.text = "STATUS: WIMP";
        }
        else if (starCount.starCount >= 15 && starCount.starCount <= 40)
        {
            level.text = "STATUS: AMATEUR";
        }
        else
        {
            level.text = "STATUS: MASTER";
        }
    }
}
