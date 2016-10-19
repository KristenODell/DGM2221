using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour
{
    private Animator anim;
   // int jumpHash = Animator.StringToHash("jump");


	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	

	void Update ()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(move));
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
       //     anim.SetTrigger(jumpHash);
       // }
    }
}
