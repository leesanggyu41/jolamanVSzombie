using UnityEngine;
using UnityEngine.SceneManagement;

public class stopy : MonoBehaviour
{
    public GameObject dogam, menu, plz;
    public string name;

    public void dogamopen()
    {
        dogam.SetActive(true);
    }
    public void can()
    {
        Time.timeScale = 1.0f;
        menu.SetActive(false);
    }
    public void Quit()
    {
        plz.SetActive(true);
    }

    public void last()
    {
        SceneManager.LoadScene(name);
    }
    public void no()
    {
        plz.SetActive(false);
    }
}
