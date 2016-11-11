using UnityEngine;
using System.Collections;

public class EnemyJumpAnimation : MonoBehaviour
{

	void Start ()
    {
	
	}

    void OnTriggerEnter()
    {
        print("jump");
    }

    void OnTriggerExit ()
    {
        print("stop jump");
    }
	
	void Update ()
    {
	
	}
}
