using UnityEngine;
using System.Collections;

public class RestartRabbitRun : MonoBehaviour
{
    private Vector3 movePos;

	void Start ()
    {
	    
	}
	

    void OnTriggerEnter()
    {
        movePos.x = SplashScreenStaticVars.originalPosition;
    }
}
