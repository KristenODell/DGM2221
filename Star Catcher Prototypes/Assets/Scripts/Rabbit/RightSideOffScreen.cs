using UnityEngine;
using System.Collections;

public class RightSideOffScreen : MonoBehaviour
{
    void Start()
    {
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 50));
    }

}