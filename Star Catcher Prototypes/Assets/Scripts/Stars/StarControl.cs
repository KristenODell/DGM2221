﻿using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour
{
    public int forceTime = 10;
    public float forceDuration = 0.1f;
    //private bool canAddForce = true;
    private Rigidbody rigid;
    private float force;
    public float forceRange = 10;
    private float torque;
    public float torqueRange = 2;
    private Vector3 forceVector;
    private Vector3 torqueVector;
    //private Animator anims;

    void Start()
    {
        //anims = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }

    IEnumerator RunRandomForce()
    {
        force = Random.Range(-forceRange, forceRange);
        torque = Random.Range(-torqueRange, torqueRange);
        while (/*canAddForce*/ forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = force;
            torqueVector.z /*-*/= /*force * 0.5f*/ torque;
            rigid.AddTorque(torqueVector);
            rigid.AddForce(forceVector);
            forceTime--;
        }
    }


    public float endTime = 5;

    //public void Deactivate()
    //{
    //    anims.SetBool("Destroy", false);
    //    gameObject.SetActive(false);
    //}

    void OnCollisionEnter()
    {
        //canAddForce = false;
        //gameObject.SetActive(false);
        Destroy(gameObject, endTime);
        //anims.SetBool("Destroy", true);
    }
}
