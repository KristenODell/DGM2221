using UnityEngine;
using System.Collections;

public class StealthMode : MonoBehaviour
{
    public float stealthMeter;
    private StarCounter starCount;

    public IEnumerator Stealth()
    {
        int i = 5;
        while (i >= 0)
        {
            gameObject.layer = 22;
            yield return new WaitForSeconds(1);
            i--;
            print("Stealth");
        }
    }

    // Use this for initialization
    void Start ()
    {
        starCount = GameObject.Find("Star Counter").GetComponent<StarCounter>();
        stealthMeter = starCount.starCount;
        //Disguise();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if(Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    StartCoroutine(Stealth());
        //    stealthMeter = 0;
        //}
        //else
        //{
        //    gameObject.layer = 11;
        //    print("Unstealth");
        //}

	}

    void Disguise ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(Stealth());
            stealthMeter = 0;
        }
        else
        {
            gameObject.layer = 11;
            print("Unstealth");
        }
    }
}
