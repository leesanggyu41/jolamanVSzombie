using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class zolaman : MonoBehaviour
{
    public float HP;
    public zombie zombie;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            zombie = collision.GetComponent<zombie>();
            InvokeRepeating("demege",0.1f,1);
        }
        if (collision.CompareTag("Boss"))
        {
            boss boss = collision.GetComponent<boss>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
            CancelInvoke("demege");
        
    }

    void demege()
    {
        HP -= zombie.DMG;
    }

    private void Update()
    {
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
