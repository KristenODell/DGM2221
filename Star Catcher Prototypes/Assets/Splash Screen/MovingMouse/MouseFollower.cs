using UnityEngine;
using System.Collections;

public class MouseFollower : MonoBehaviour
{
    public float distance = 50;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = distance;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
	}
}
