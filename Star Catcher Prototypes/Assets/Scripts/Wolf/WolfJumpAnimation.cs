using UnityEngine;
using System.Collections;

public class WolfJumpAnimation : MonoBehaviour
{
    public Animator myAnim;
    private EnemyMovement enemyJumpSpeed;
    public float newJumpSpeed = 50;
    public float originalSpeed;

	// Use this for initialization
	void Start ()
    {
        enemyJumpSpeed = GameObject.Find("Enemy").GetComponent<EnemyMovement>();
        originalSpeed = enemyJumpSpeed.speed;

    }
	
    void OnTriggerEnter ()
    {
        myAnim.SetBool("jump", true);
        enemyJumpSpeed.speed = newJumpSpeed;

    }

    void OnTriggerExit()
    {
        myAnim.SetBool("jump", false);
        enemyJumpSpeed.speed = originalSpeed;
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
