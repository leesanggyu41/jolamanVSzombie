using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleee : MonoBehaviour
{
    public GameObject plz;
    public string stagename, title;
    public void nextstage()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(stagename);
    }
    public void oust()
    {
        plz.SetActive(true);
    }
    public void last()
    {
        SceneManager.LoadScene(title);
    }
    public void can()
    {
        plz.SetActive(false);
    }

}
