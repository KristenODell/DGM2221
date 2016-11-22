using UnityEngine;
using System.Collections;

public class OffScreen : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 50));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
