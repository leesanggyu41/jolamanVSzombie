using System.Collections;
using UnityEngine;

public class cooldown : MonoBehaviour
{
    public slot slot;
    public float cooltime;


    private void Update()
    {
        if (slot.um == false)
        slot.um = true;
        StartCoroutine(cool());
    }


    IEnumerator cool()
    {
        yield return new WaitForSeconds(cooltime);
        slot.um = false;
        gameObject.SetActive(false);
    }
}
