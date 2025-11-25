using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float cool;
    public GameObject Bulletpre;
    public Transform point;
    public Animator Anim;
    public bool SHOT, umm;
    private Collider2D target;
    public AudioSource gunsound;
    public List<GameObject> zombie = new List<GameObject>();
    public int a;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            zombie.Add(collision.gameObject);
        }
        if (collision.CompareTag("Boss"))
        {
            zombie.Add(collision.gameObject);
        }
    }

    public void Update()
    {
        if (!SHOT)
        {
            if(zombie.Count > 0)
            {
                
                SHOT = true;
                InvokeRepeating("Shoot", 0.2f, cool);
            } 
        }
        else
        {
            a = 0;
            foreach (GameObject obj in zombie)
            {
                if (obj == null)
                {
                    a++;
                }
            }
            if (a == zombie.Count)
            {
                SHOT = false;
                CancelInvoke("Shoot");
            }
        }
    }

    void Shoot()
    {
            Anim.SetBool("shot", true);
            gunsound.Play();
            GameObject bullet = Instantiate(Bulletpre, point.position, Quaternion.identity);
            umm = true;
            Debug.Log("shot");

        Anim.SetBool("shot", false);
        umm = false;
    }
    
}
