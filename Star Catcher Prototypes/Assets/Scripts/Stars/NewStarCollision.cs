using UnityEngine;
using System.Collections;

public class NewStarCollision : MonoBehaviour
{

    private StarCounter starCounter;
    public GameObject star;


    // Use this for initialization
    void Awake()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }


    void OnCollisionEnter()
    {
        starCounter.starCount++;
        star.SetActive(false);
    }


}
