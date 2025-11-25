using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public int DMG;

    private void Start()
    {
        Invoke("ricoshot",10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            zombie zombie = collision.gameObject.GetComponent<zombie>();
            if (zombie != null)
            {
                zombie.HP -= DMG;
                Destroy(gameObject);
            }

        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            boss boss = collision.gameObject.GetComponent<boss>();
            if (boss != null)
            {
                boss.HP -= DMG;
                Destroy(gameObject);
            }
        }
    }
    private void Update()
    {
        transform.position += new Vector3(speed,0,0);
    }
    void ricoshot()
    {
        Destroy(gameObject);
    } 
}
