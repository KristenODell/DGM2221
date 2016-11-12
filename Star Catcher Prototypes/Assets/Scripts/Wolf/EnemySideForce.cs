using UnityEngine;
using System.Collections;

public class EnemySideForce : MonoBehaviour
{

    public CharacterController myCC;
    Vector3 tempPos;
    public float sideForce = 1;

    // Use this for initialization
    void Start()
    {
        myCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        tempPos.z = sideForce;
        myCC.Move(tempPos);
    }
}
