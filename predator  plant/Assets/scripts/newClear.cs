using UnityEngine;
using UnityEngine.SceneManagement;

public class newClear : MonoBehaviour
{
    public string scenename;
    public Animator cameraanimator;
    public AudioSource AudioSource;
    private void Start()
    {
        Invoke("camerA", 5f);
        Invoke("clear", 10);
    }

    void camerA()
    {
        AudioSource.Play();
        cameraanimator.SetBool("move",true);
    }

    void clear()
    {
        SceneManager.LoadScene(scenename);
    }
}
