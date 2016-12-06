using UnityEngine;
using System.Collections;

public class StealthModeBlackHole : MonoBehaviour {

    public int stealthTime = 10;
    private StealthCounter stealthCount;

    public IEnumerator Stealth()
    {
        gameObject.layer = 22;
        yield return new WaitForSeconds(stealthTime);
        gameObject.layer = 25;
    }

    void Start()
    {
        stealthCount = GameObject.Find("Stealth").GetComponent<StealthCounter>();
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && stealthCount.stealthCount >= 5)
        {
            StartCoroutine(Stealth());
        }
    }
}
