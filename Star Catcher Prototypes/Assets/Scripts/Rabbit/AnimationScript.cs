using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour
{
    private Animator anim;
    public CharacterController cc;
    //int jumpHash = Animator.StringToHash("jump");


    void Start()
    {
        anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }


    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("speed", Mathf.Abs(move));
        // if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    anim.SetTrigger(jumpHash);
        //}
        //  if(cc.isGrounded)
        //  {
        //      anim.ResetTrigger(jumpHash);
        // }
        //if (!cc.isGrounded && Input.GetKeyDown(KeyCode.Space))
       // {
       //     anim.SetTrigger(jumpHash);
       // }
       //  else
      //  {
       //     anim.ResetTrigger(jumpHash);
            // anim.SetBool("landing", false);
       // }
        //  if(myRig.velocity.y < 0)
        // {
        //     anim.SetBool("landing", true);
        // }
    }
}
