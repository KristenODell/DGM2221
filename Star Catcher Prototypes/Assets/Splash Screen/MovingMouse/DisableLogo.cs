using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisableLogo : MonoBehaviour
{
    public int TimeUpFont = 300;
    public Canvas background;
    public GameObject logo;

    public IEnumerator FadeOutLogo()
    {
        yield return new WaitForSeconds(TimeUpFont * Time.deltaTime);
        background.enabled = false;
        logo.SetActive(false);

    }

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(FadeOutLogo());
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
