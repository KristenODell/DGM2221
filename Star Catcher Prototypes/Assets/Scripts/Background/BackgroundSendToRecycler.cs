using UnityEngine;
using System.Collections;
using System;

public class BackgroundSendToRecycler : MonoBehaviour
{
    public bool canRecycle;

    public static Action<BackgroundSendToRecycler> SendThis;

    void Start()
    {
        if (canRecycle && SendThis != null)
        {
            SendThis(this);
        }
    }

    void OnTriggerEnter()
    {
        canRecycle = true;
        Start();
    }

}
