using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LeftOffScreenRestart : MonoBehaviour
{
    void Start()
    {
        //transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
    }

    void OnTriggerEnter()
    {
        Statics.nextPosition = Statics.originalPosition;
        SceneManager.LoadScene("Prototype One");
    }
}
