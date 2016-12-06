using UnityEngine;
using System.Collections;

public class RedStarCollision : MonoBehaviour
{

    private StealthCounter stealthCount;
    public GameObject redStar;

    // Use this for initialization
    void Awake()
    {
        stealthCount = GameObject.Find("Stealth").GetComponent<StealthCounter>();
    }


    void OnCollisionEnter()
    {
            stealthCount.stealthCount++;
            redStar.SetActive(false);
    }

}

