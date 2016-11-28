using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StealthCounter : MonoBehaviour
{
    public float stealthCount = 0;
    public Text counter;
    public GameObject glow;

    void Start()
    {
        counter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "STEALTH METER: " + stealthCount;
        if (stealthCount < 0)
        {
            stealthCount = 0;
        }
        if(stealthCount >= 5)
        {
            stealthCount = 5;
            counter.color = Color.red;
        }
        else
        {
            counter.color = Color.white;
        }
    }
}