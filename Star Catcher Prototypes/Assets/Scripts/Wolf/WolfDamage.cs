using UnityEngine;
using System.Collections;

public class WolfDamage : MonoBehaviour
{
    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
	
	}

    void OnTriggerEnter()
    {
        enemy.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
