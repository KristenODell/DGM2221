using UnityEngine;
using System.Collections;
using System;

public class StarTrigger : MonoBehaviour
{
    bool alive = true;
    public int timer = 4;
    public GameObject star;

    IEnumerator Stars ()
    {
        while (alive)
        {
            star.SetActive(false);
            yield return new WaitForSeconds(timer);
            star.SetActive(true);
        }
    }
    
    void OnTriggerEnter ()
    {
        Stars();
    }
}
