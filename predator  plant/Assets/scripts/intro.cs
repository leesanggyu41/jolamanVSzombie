using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class intro : MonoBehaviour
{

    public void Startt()
    {
        SceneManager.LoadScene("game1");
    }

    public void Quitt()
    {
        Application.Quit();
    }
}
