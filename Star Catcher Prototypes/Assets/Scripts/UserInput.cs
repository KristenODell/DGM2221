using UnityEngine;
using System.Collections;
using System;
using UnityEngine.Experimental.Director;

public class UserInput : MonoBehaviour
{
    public static Action<KeyCode> userInput;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow) && userInput != null)
        {
            userInput(KeyCode.RightArrow);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && userInput != null)
        {
            userInput(KeyCode.LeftArrow);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && userInput != null)
        {
            userInput(KeyCode.UpArrow);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && userInput != null)
        {
            userInput(KeyCode.DownArrow);
        }
    }

}
