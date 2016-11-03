using UnityEngine;
using System.Collections;

public class StarCollision : MonoBehaviour
{

    private StarCounter starCounter;
    public Transform myTransform;

	// Use this for initialization
	void Awake ()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
        myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        myTransform.position = myTransform.position + Vector3.zero;
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
