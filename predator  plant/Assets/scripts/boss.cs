using UnityEngine;

public class boss : MonoBehaviour
{
    public int HP;
    public float speed;
    public bool atteck;
    public Animator anim;
    public SpriteRenderer oj;
    public Sprite[] song;
    public GameObject Target;
    public AudioSource eating;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("zolaman"))
        {
            Target = collision.gameObject;
            anim.SetBool("work", false);
            Invoke("A", 0.1f);
        }
    }
    void A()
    {
        oj.sprite = song[0];
        Invoke("t", 0.1f);
    }
    void t()
    {
        oj.sprite = song[1];
        Invoke("T", 0.1f);
    }
    void T()
    {
        oj.sprite = song[2];
        Invoke("e", 0.1f);
    }
    void e()
    {
        oj.sprite = song[3];
        Invoke("c", 0.1f);
    }
    void c()
    {
        eating.Play();
        oj.sprite = song[4];
        Invoke("k", 0.1f);
    }
    void k()
    {
        anim.SetBool("work", false);
        oj.sprite = song[5];
        Destroy(Target);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        atteck = false;
    }
    public void Update()
    {
        if (!atteck)
        {
            anim.SetBool("work", true);
            transform.position -= new Vector3(speed, 0, 0);
        }
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
