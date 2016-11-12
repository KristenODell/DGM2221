using UnityEngine;
using System.Collections;

public class WolfJumpAnimation : MonoBehaviour
{
    public Animator myAnim;

	// Use this for initialization
	void Start ()
    {

	}
	
    void OnTriggerEnter ()
    {
        myAnim.SetBool("jump", true);
    }

    void OnTriggerExit()
    {
        myAnim.SetBool("jump", false);
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
