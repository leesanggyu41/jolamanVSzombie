using UnityEngine;
using UnityEngine.UI;
public class last : MonoBehaviour
{
    public GameObject butt;
    public Slider round;


    private void Update()
    {
        if (round.value == 179)
        {
            butt.SetActive(true);
        }
    }
}
