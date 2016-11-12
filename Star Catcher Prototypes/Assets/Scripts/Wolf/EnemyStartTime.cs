using UnityEngine;
using System.Collections;

public class EnemyStartTime : MonoBehaviour
{
    public float startTime = 15;
    public GameObject enemy;

    IEnumerator StartEnemy()
    {
        int i = 1;
        while (i > 0)
        {
            yield return new WaitForSeconds(startTime);
            enemy.SetActive(true);
            i--;
        }
    }

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(StartEnemy());
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
