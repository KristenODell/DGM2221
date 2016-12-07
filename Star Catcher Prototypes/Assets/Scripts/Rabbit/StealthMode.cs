using UnityEngine;
using System.Collections;

public class StealthMode : MonoBehaviour
{
    private StealthCounter stealthCount;
    public int stealthTime = 7;
    public float subtractingStealthMeter = 5;
    public SpriteRenderer spriteRenderer;
    public GameObject halo;
    public GameObject starCollision;
    public GameObject stealthStarCollision;
    public GameObject blackHoleCollision;


    public IEnumerator Stealth()
    {
        starCollision.SetActive(false);
        stealthStarCollision.SetActive(false);
        blackHoleCollision.SetActive(false);
        gameObject.layer = 22;
        spriteRenderer.material.SetColor("_Color", Color.black);
        halo.SetActive(true);
        yield return new WaitForSeconds(stealthTime);
        gameObject.layer = 11;
        starCollision.SetActive(true);
        stealthStarCollision.SetActive(true);
        blackHoleCollision.SetActive(true);
        halo.SetActive(false);
        spriteRenderer.material.SetColor("_Color", Color.white);
    }

    // Use this for initialization
    void Start ()
    {
        stealthCount = GameObject.Find("Stealth").GetComponent<StealthCounter>();
        spriteRenderer = GameObject.Find("rabbitIdle").GetComponent<SpriteRenderer>();
        halo.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && stealthCount.stealthCount >= 5)
        {
            StartCoroutine(Stealth());
            stealthCount.stealthCount -= subtractingStealthMeter;
        }

	}

    //void Disguise ()
    //{
    //    if (Input.GetKeyDown(KeyCode.UpArrow))
    //    {
    //        StartCoroutine(Stealth());
    //        stealthMeter = 0;
    //    }
    //    else
    //    {
    //        gameObject.layer = 11;
    //        print("Unstealth");
    //    }
    //}
}
