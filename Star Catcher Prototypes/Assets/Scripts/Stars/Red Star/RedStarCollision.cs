﻿using UnityEngine;
using System.Collections;

public class RedStarCollision : MonoBehaviour
{

    private StealthCounter stealthCount;


    // Use this for initialization
    void Awake()
    {
        stealthCount = GameObject.Find("Stealth").GetComponent<StealthCounter>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(.1f, .1f, 0);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        starCounter.starCount++;
    //        gameObject.SetActive(false);
    //        //Destroy(collision.gameObject);
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            stealthCount.stealthCount++;
            gameObject.SetActive(false);
        }
    }

}
