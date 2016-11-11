using UnityEngine;
using System.Collections;

public class EnemyJumpAnimation : MonoBehaviour
{
    public Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Jump", false);
	}

    void OnTriggerEnter()
    {
        print("jump");
        anim.SetBool("Jump", true);
    }

    void OnTriggerStay ()
    {
        anim.SetBool("Jump", true);
    }

    void OnTriggerExit ()
    {
        print("stop jump");
        anim.SetBool("Jump", false);
    }
	
	void Update ()
    {
	
	}
}
