using UnityEngine;
using System.Collections;

public class DestroyWolf : MonoBehaviour
{
    public Transform wolf;
    public Transform startPoint;
   

	// Use this for initialization
	void Start ()
    {
	}

    void OnTriggerEnter ()
    {
        wolf.position = startPoint.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}
}
