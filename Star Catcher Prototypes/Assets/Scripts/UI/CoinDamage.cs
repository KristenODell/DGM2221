﻿using UnityEngine;
using System.Collections;

public class CoinDamage : MonoBehaviour
{
    private StarCounter starCounter;
    private int damage = 2;
    public GameObject playerHalo;
    public float wait = 2;
    public float damageNumberWait = 5;

    public GameObject damageNumber;

    public IEnumerator damageHalo ()
    {
        playerHalo.SetActive(true);
        yield return new WaitForSeconds(wait);
        playerHalo.SetActive(false);
    }

    public IEnumerator damageNumberFlash ()
    {
        damageNumber.SetActive(true);
        yield return new WaitForSeconds(damageNumberWait);
        damageNumber.SetActive(false);
    }

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
            StartCoroutine(damageHalo());
            StartCoroutine(damageNumberFlash());
        }
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
