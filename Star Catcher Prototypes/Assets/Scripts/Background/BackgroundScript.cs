using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 tempPos;

    void Update()
    {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
    }

}
