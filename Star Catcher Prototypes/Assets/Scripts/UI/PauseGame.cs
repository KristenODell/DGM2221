using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    public Button pause;
    public AudioSource backgroundMusic;

    private AudioSource buttonClickSource;
    public AudioClip buttonClick;


    // Use this for initialization
    void Start()
    {
        buttonClickSource = GetComponent<AudioSource>();
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
            buttonClickSource.PlayOneShot(buttonClick);
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            pause.enabled = false;
            backgroundMusic.Pause();
        }
        else
        {
            buttonClickSource.PlayOneShot(buttonClick);
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            pause.enabled = true;
            backgroundMusic.Play();
        }
    }
}