using System.Collections;
using UnityEngine;

public class MushVenom : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(mushroom());
    }
    
    IEnumerator mushroom()
    {
        yield return new WaitForSeconds(1.4f);
        Destroy(gameObject);
    }
}
