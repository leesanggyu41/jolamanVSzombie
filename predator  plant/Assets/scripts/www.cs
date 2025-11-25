using UnityEngine;

public class www : MonoBehaviour
{
    public Texture2D x;
    public Texture2D y;
    public GameObject tim;
    private void Start()
    {
        y = null;
    }
    public void ww()
    {
        if (x == y)
        {
            tim.SetActive(false);
            y = null;
            Cursor.SetCursor(null,Vector2.zero, CursorMode.Auto);
        }
        else
        {
            tim.SetActive(true);
            y = x;
            Cursor.SetCursor(x, Vector2.zero, CursorMode.Auto);
        }
    }
}
