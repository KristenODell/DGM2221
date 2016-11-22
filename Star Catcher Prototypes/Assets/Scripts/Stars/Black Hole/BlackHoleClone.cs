using UnityEngine;
using System.Collections;

public class BlackHoleClone : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform star;
    public float spawnFrequency = 1;
    public bool canSpawnStars = true;
    public float wait = 5;

    private int i = 0;

    IEnumerator SpawnStars()
    {
        while (canSpawnStars)
        {
            i = Random.Range(0, spawnPoints.Length - 1);
            Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
        }
    }
    IEnumerator WaitToBegin()
    {
        yield return new WaitForSeconds(wait);
        StartCoroutine(SpawnStars());
    }

    void Start()
    {
        StartCoroutine(WaitToBegin());
    }
}
