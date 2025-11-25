using UnityEngine;
using UnityEngine.SceneManagement;
public class ESC : MonoBehaviour
{

    public GameObject esc;

    public void pus()
    {
        esc.SetActive(true);
        Time.timeScale = 0;
    }
}
