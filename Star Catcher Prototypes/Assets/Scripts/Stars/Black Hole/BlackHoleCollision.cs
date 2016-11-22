using UnityEngine;
using System.Collections;

public class BlackHoleCollision : MonoBehaviour
{

    private StarCounter starCounter;


    void Awake()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }

    void Start()
    {

    }


    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            starCounter.starCount--;
            //gameObject.SetActive(false);
        }
    }

}
