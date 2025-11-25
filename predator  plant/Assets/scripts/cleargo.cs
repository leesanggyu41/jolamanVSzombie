using UnityEngine;
using UnityEngine.SceneManagement;

public class cleargo : MonoBehaviour
{
    public string Name;

    public void click()
    {
        SceneManager.LoadScene(Name);
    }
}
