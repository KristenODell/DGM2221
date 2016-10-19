using UnityEngine;
using System.Collections;
using System;

public class SplashScreenPlayerMovement : MonoBehaviour
{

    private CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 1;
    public float gravity = 1;


    void Start()
    {
        myCC = GetComponent<CharacterController>();
    }

    void Update()
    {
        tempPos.y -= gravity;
        tempPos.x = speed;
        myCC.Move(tempPos * Time.deltaTime);
    }

    void OnTriggerEnter()
    {
        tempPos.x = SplashScreenStaticVars.originalPosition;
    }
}