using UnityEngine;
using System.Collections;

public class CloneStar : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform star;
    //public GameObject[] stars;
    public float spawnFrequency = 1;
    public bool canSpawnStars = true;

    private int i = 0;
    //private int j = 0;
    //private int j = 0;

    IEnumerator SpawnStars()
    {
        while (canSpawnStars)
        {
            i = Random.Range(0, spawnPoints.Length - 1);
            //j = Random.Range(0, stars.Length - 1);
            //stars[j].SetActive(true);
            //stars[j].transform.position = spawnPoints[i].position;

            //if (j < stars.Length - 1)
            //{
            //    stars[j].SetActive(true);
            //    stars[j].transform.position = spawnPoints[i].position;
            //    j++;
            //}
            //else
            //{
            //    j = 0;
            //}
            //instatiate star to spawnPoints
            //quaternion resets to zero
             Instantiate(star, spawnPoints[i].position, Quaternion.identity);
            yield return new WaitForSeconds(spawnFrequency);
        }
    }

    void Start()
    {
        StartCoroutine(SpawnStars());
    }

}
