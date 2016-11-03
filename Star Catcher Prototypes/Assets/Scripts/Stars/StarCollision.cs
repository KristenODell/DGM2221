using UnityEngine;
using System.Collections;

public class StarCollision : MonoBehaviour
{

    private StarCounter starCounter;

    public float speed = 0;
    private Vector3 tempPos;

    // Use this for initialization
    void Awake()
    {
        starCounter = GameObject.Find("Star Counter").GetComponent<StarCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
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
            starCounter.starCount++;
            gameObject.SetActive(false);
        }
    }

}

