using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class EnemyMovement : MonoBehaviour
{
    public Vector3 startPoint;
    private CharacterController myCC;
    public float gravity = 1;
    public float speed = 1;
    public float fallingSpeed = 1;
    private Vector3 tempP;


    // Use this for initialization
    void Start()
    {
        startPoint = transform.position;
        myCC = GetComponent<CharacterController>();
    }

    void OnTriggerEnter()
    {
        ////if (myCC.velocity.x < 40)
        ////{
        ////    gravity *= 1.5f;
        ////}
        //speed *= -1;
        ////transform.position = startPoint;
    }

    // Update is called once per frame
    void Update()
    {
        //print(myCC.velocity);
        tempP.y = gravity;
        myCC.Move(tempP * Time.deltaTime);
        if (myCC.isGrounded)
        {
            tempP.x = speed;
        }
        else
        {
            tempP.x = fallingSpeed;
        }
    }
}
