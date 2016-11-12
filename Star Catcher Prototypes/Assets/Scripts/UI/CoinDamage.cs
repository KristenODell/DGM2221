using UnityEngine;
using System.Collections;

public class CoinDamage : MonoBehaviour
{
    private StarCounter starCounter;
    private int damage = 3;

	// Use this for initialization
	void Start ()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }
	
    void OnTriggerEnter()
    {
        if (starCounter.starCount > 0)
        {
            starCounter.starCount -= damage;
        }
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
