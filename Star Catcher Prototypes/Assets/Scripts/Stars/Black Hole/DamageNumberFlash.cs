using UnityEngine;
using System.Collections;

public class DamageNumberFlash : MonoBehaviour {

    public GameObject damageNumber;
    public float damageNumberWait = 1;

    public IEnumerator damageNumberFlash()
    {
        damageNumber.SetActive(true);
        yield return new WaitForSeconds(damageNumberWait);
        damageNumber.SetActive(false);
    }

    void OnTriggerEnter()
    {
        StartCoroutine(damageNumberFlash());
    }

}
