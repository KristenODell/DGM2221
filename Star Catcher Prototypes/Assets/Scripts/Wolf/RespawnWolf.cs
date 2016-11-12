using UnityEngine;
using System.Collections;

public class RespawnWolf : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] wolf;
    public float spawnFrequency = 1;
    public bool canSpawnWolf = true;

    private int i = 0;
    private int j = 0;

    IEnumerator SpawnWolf()
    {
        while (canSpawnWolf)
        {
            i = Random.Range(0, spawnPoints.Length - 1);
            wolf[j].SetActive(true);
            wolf[j].transform.position = spawnPoints[i].position;

            if (j < wolf.Length - 1)
            {
                wolf[j].SetActive(true);
                wolf[j].transform.position = spawnPoints[i].position;
                j++;
            }
            else
            {
                j = 0;
            }
            //instatiate star to spawnPoints
            //quaternion resets to zero
            // Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
        }
    }

    void Start()
    {
        StartCoroutine(SpawnWolf());
    }

    void Update()
    {

    }
}
