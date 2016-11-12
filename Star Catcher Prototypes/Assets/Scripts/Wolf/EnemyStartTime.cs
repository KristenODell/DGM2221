using UnityEngine;
using System.Collections;

public class EnemyStartTime : MonoBehaviour
{
    public int startTime = 15;
    public int otherStartTime = 7;
    public GameObject enemy;

    IEnumerator StartEnemy()
    {
        int startTimeIndex = Random.Range(otherStartTime, startTime);
        int i = 1;
        while (i > 0)
        {
            yield return new WaitForSeconds(startTimeIndex);
            enemy.SetActive(true);
            i--;
        }
        print(startTimeIndex);
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
