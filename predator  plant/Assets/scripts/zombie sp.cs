using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class zombiesp : MonoBehaviour
{
    public Transform[] point;
    public GameObject[] zombie;
    private bool sta, ba;
    public int zombiejong;
    public float cool;
    public Slider ww;
    public GameObject sto;
    public AudioSource Zombie;


    public void Start()
    {
        StartCoroutine(Delay());
    }


    private void Update()
    {
        if (ww.value == 300)
        {
            CancelInvoke("sp");
        }
        if (sto.active == false)
        {
            if (!ba)
            {
                Invoke("sp", cool);
                ba = true;
            }
        }
        if (ww.value >= 60)
        {
            zombiejong = 3;
        }
        if (ww.value >= 120 && zombie.Length == 4)
        {
            zombiejong = 4;
        }
    }

    void sp()
    {
            Zombie.Play();
            ba = false;
            int a = Random.Range(0, point.Length);
            int b = Random.Range(0, zombiejong);
            GameObject zomzom = Instantiate(zombie[b], point[a].position, Quaternion.identity);
        
    }

    IEnumerator Delay()
    {
        while (true)
        {
            yield return new WaitForSeconds(20f);
            cool -= 1f; 
            
        }
    }
}
