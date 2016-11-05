using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private bool paused;

    public bool Paused
    {
        get { return paused; }
    }

    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = GameObject.FindObjectOfType<GameManager>();
            }
            return GameManager.instance;
        }
    }

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    public void PauseGame()
    {
        paused = !paused;
    }
}
