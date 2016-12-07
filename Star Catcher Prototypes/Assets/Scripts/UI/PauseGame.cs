using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    public Button pause;
    public AudioSource backgroundMusic;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    if (canvas.gameObject.activeInHierarchy == false)
        //    {
        //        canvas.gameObject.SetActive(true);
        //        Time.timeScale = 0;
        //    }
        //    else
        //    {
        //        canvas.gameObject.SetActive(false);
        //        Time.timeScale = 1;
        //    }
        //}

    }

    public void PauseTheGame()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            pause.enabled = false;
            backgroundMusic.Pause();
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            pause.enabled = true;
            backgroundMusic.Play();
        }
    }
}