using UnityEngine;
using System.Collections;

public class StarCollision : MonoBehaviour
{

    private StarCounter starCounter;

	// Use this for initialization
	void Awake ()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    
    //void OnCollisionEnter(Collision collision)
    void OnTriggerEnter()
    {
        //if(collision.gameObject.tag == "Player")
        // {
        starCounter.starCount++;
            gameObject.SetActive(false);
        //Destroy(collision.gameObject);
        //}
    }

}
