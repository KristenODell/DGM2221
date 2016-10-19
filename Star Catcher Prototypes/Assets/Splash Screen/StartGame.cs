using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {


	void Start ()
    {
	
	}
	

    void OnMouseDown ()
    {
        SceneManager.LoadScene("Prototype One");
    }
}
