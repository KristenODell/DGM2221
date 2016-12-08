using UnityEngine;
using System.Collections;

public class DestroyWolf : MonoBehaviour
{
    public Transform wolf;
    public Transform startPoint;

    void OnTriggerEnter ()
    {
        wolf.position = startPoint.position;
    }

}
