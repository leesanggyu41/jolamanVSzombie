using UnityEngine;
using UnityEngine.UI;

public class round : MonoBehaviour
{
    public Slider rond;
    void Start()
    {
        InvokeRepeating("ro",30,1);
    }

    private void ro()
    {
        rond.value += 1;
    }
}
