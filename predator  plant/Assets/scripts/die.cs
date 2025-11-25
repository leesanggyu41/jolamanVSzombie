using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject over;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            over.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.CompareTag("Boss"))
        {
            over.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
