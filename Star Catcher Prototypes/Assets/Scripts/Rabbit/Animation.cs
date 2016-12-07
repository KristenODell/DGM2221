using UnityEngine;
using System.Collections;

public class Animation : MonoBehaviour {
    public MovePlayer myMoveCharacter;
    public Animator myAnimator;
    //private float _h;

    // Use this for initialization
    void Start () {
        //myMoveCharacter = new MovePlayer();
        myAnimator = GetComponent<Animator>();
        //myMoveCharacter.myCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        myAnimator.SetFloat("speed", Mathf.Abs(move));
        //if (!myMoveCharacter.myCC.isGrounded)
        //{
        //    myAnimator.SetLayerWeight(0, 0);
        //}
        //else
        //{
        //    myAnimator.SetLayerWeight(1, 1);
        //    myAnimator.SetBool("Jump", false);
        //    myAnimator.SetBool("Double Jump", false);
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (myMoveCharacter.myCC.isGrounded)
        //    {
        //        myAnimator.SetBool("Jump", true);
        //    }
        //    if (!myMoveCharacter.myCC.isGrounded && myMoveCharacter.jumpCount < myMoveCharacter.jumpCountMax)
        //    {
        //        myAnimator.SetBool("Jump", false);
        //        myAnimator.SetBool("Double Jump", true);
        //    }
        //}
    }
}
