using NUnit.Framework;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.TextCore.Text;
using static UnityEngine.GraphicsBuffer;

public class bomb : MonoBehaviour
{
    public GameObject boomer;
    public List<GameObject> zombie = new List<GameObject>();
    public int DMG;
    private zombie zom;
    private boss bo;

    private void Start()
    {
        Invoke("SeongHyeonWon",1);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("엄준식");
        if (other.transform.CompareTag("Zombie") || other.transform.CompareTag("Boss"))
        {
            Debug.Log("드러감");
            zombie.Add(other.gameObject);
        }

        
    }

    void SeongHyeonWon()
    {
        foreach (GameObject obj in zombie)
        {
            if (obj != null)
            {
                if (obj.CompareTag("Zombie"))
                {
                    zom = obj.GetComponent<zombie>();
                    zom.HP -= DMG;
                }else if (obj.CompareTag("Boss"))
                {
                    bo = obj.GetComponent<boss>();
                    bo.HP -= DMG;
                }
                
                
            }
        }
        Transform j = gameObject.transform.parent;
        GameObject Prefep = Instantiate(boomer);
        Prefep.transform.parent = j;
        Prefep.transform.localPosition = Vector3.zero;
        Destroy(gameObject);
    }

}
