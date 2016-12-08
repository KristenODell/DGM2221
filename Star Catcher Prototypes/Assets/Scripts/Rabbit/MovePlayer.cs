using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{

    //This is the character controller component
    public CharacterController myCC;
    //Temp var of datatype Vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float gravity = 9.81f;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //Sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.1f;
    public float deathHeight = -100f;

    public GameObject star;


    public GameObject gameOverText;
    public GameObject EndGameScreen;
    public GameObject pause;
    public GameObject starScreen;
    public Text text;
    public Text starCount;
    public Text stealthCount;
    public int timeUpFont = 150;
    public GameObject player;
    public AudioSource backgroundMusic;
    public GameObject numberFlash;
    public GameObject particles;


    public IEnumerator IGameOverText()
    {
        backgroundMusic.volume = 0;
        player.SetActive(false);
        numberFlash.SetActive(false);
        particles.SetActive(false);
        text.enabled = false;
        pause.SetActive(false);
        starScreen.SetActive(false);
        starCount.enabled = false;
        stealthCount.enabled = false;
        gameOverText.SetActive(true);
        yield return new WaitForSeconds(timeUpFont * Time.deltaTime);
        backgroundMusic.volume = .02f; ;
        EndGameScreen.SetActive(true);
    }

    //Coroutine for sliding the character. Coroutines are IEnumerators.
    IEnumerator Slide()
    {
        //Set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float speedTemp = speed;
        speed += speed;
        //While loop runs "while" the slide duration is greater than 0.
        while (slideDuration > 0)
        {
            //Decrement the slideDuration
            slideDuration--;
            //Yield "holds the coroutine"
            //Return "sends" to the coroutine to do an operation while yielding
            //New creates an instance of an object
            //WaitForSeconds is an object that waits for a duration of time
            yield return new WaitForSeconds(slideTime);

        }
        speed = speedTemp;
        slideDuration = durationTemp;
    }


    // Use this for initialization
    void Start()
    {
        //This "finds" the character controller component
        myCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Waiting for input and comparing jumpCount.
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax - 1)
        {
            //Incrementing the jumpCount by one.
            jumpCount++;
            //Adding the jumpSpeed var to the tempPos var.
            tempPos.y = jumpSpeed;
        }
        //Start sliding
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument.
            StartCoroutine(Slide());
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument.
            StartCoroutine(Slide());
        }

        //Test if the charactercontroller is grounded.
        if (myCC.isGrounded)
        {
            //Reset the jumpCount if it is grounded.
            jumpCount = 0;
        }

        //Adding the gravity var to the y position of the tempPos var.
        tempPos.y -= gravity * Time.deltaTime;
        //Adding the speed var to the tempPos var x value with the right and left arrow keys.
        tempPos.x = speed * Input.GetAxis("Horizontal");
        //Moves the charactercontroller at an even pace.
        myCC.Move(tempPos * Time.deltaTime);
        tempPos.z = 0;
        

        if (transform.position.y <= deathHeight)
        {
            //Statics.nextPosition = Statics.originalPosition;
            //Statics.backgroundNextPosition = Statics.backgroundOriginalPosition;
            //SceneManager.LoadScene("Prototype One");
            StartCoroutine(IGameOverText());
        }
    }
}