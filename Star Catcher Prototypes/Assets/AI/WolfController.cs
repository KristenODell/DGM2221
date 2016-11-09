using UnityEngine;
using System.Collections;

public class WolfController : MonoBehaviour
{
    public CharacterController myCC;
    public float gravity = 1;
    public Vector3 tempPos;


    void Start()
    {

    }


    void Update()
    {
        tempPos.y -= gravity * Time.deltaTime;
        myCC.Move(tempPos);
        tempPos.z = 0;
    }
}