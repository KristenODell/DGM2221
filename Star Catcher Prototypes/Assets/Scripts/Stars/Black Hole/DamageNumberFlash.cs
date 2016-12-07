using UnityEngine;
using System.Collections;

public class DamageNumberFlash : MonoBehaviour {

    public GameObject damageNumber;
    public float damageNumberWait = 2;
    public GameObject playerHalo;
    public float wait = 2;

    public IEnumerator damageNumberFlash()
    {
        damageNumber.SetActive(true);
        yield return new WaitForSeconds(damageNumberWait);
        damageNumber.SetActive(false);
    }
    public IEnumerator damageHalo()
    {
        playerHalo.SetActive(true);
        yield return new WaitForSeconds(wait);
        playerHalo.SetActive(false);
    }

    void OnTriggerEnter()
    {
        StartCoroutine(damageNumberFlash());
        StartCoroutine(damageHalo());
    }

}
