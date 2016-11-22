using UnityEngine;
using System.Collections;

public class StealthMode : MonoBehaviour
{
    private StealthCounter stealthCount;
    private MovePlayer characterController;
    public int stealthTime = 10;
    public float subtractingStealthMeter = 5;
    public SpriteRenderer spriteRenderer;
    private Color color;
    private Color color2;


    public IEnumerator Stealth()
    {
        gameObject.layer = 22;
        spriteRenderer.material.SetColor("_Color", Color.black);
        yield return new WaitForSeconds(stealthTime);
        gameObject.layer = 11;
        spriteRenderer.material.SetColor("_Color", Color.white);
    }

    // Use this for initialization
    void Start ()
    {
        stealthCount = GameObject.Find("Stealth").GetComponent<StealthCounter>();
        spriteRenderer = GameObject.Find("rabbitIdle").GetComponent<SpriteRenderer>();
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
