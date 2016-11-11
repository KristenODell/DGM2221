using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarCounter : MonoBehaviour
{
    public float starCount = 0;
    public Text counter;

    void Start ()
    {
        counter = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        counter.text = "STAR COUNT: " + starCount;
        if(starCount < 0)
        {
            starCount = 0;
        }
	}
}
