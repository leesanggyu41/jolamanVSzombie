using UnityEngine;

public class intro1 : MonoBehaviour
{
    public GameObject[] tex;
    public int a;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (a < 5) { 
                tex[a].SetActive(true);
            a++;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}
