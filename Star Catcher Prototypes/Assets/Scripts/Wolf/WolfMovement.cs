﻿using UnityEngine;
using System.Collections;

public class WolfMovement : MonoBehaviour
{
    public float speed = 1;
    private Vector3 tempPos;

    void Start()
    {

    }

    void Update()
    {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
    }
}
