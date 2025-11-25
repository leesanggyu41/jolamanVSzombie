using System.Collections;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public Sprite um,jun,sic;
    public SpriteRenderer ob;
    public float speed;
    private bool work = true;
    public AudioSource eat;

    public int HP, DMG;

    private void Start()
    {
        Invoke("se",0.1f);
    }

    void se()
    {
        ob.sprite = jun;
        Invoke("hoon", 0.1f);
    }
    void hoon()
    {
        ob.sprite = sic;
        Invoke("im",0.1f);
    }
    void im()
    {
        ob.sprite = um;
        Invoke("se", 0.1f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("zolaman"))
        {
            work = false;
            eat.Play();
            transform.position -= new Vector3(0,0,0);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("zolaman"))
        {
            eat.Stop();
            work = true;
        }
    }

    private void FixedUpdate()
    {
        if (work)
        {
            transform.position -= new Vector3(speed, 0, 0);
        }
        if (HP <= 0)
        {
            Destroy(gameObject);
        }

    }
    
    
}
