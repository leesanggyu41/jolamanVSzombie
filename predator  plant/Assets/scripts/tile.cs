using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int y, z;
    public gamemanager manager;
    public bool chok;
    public Image uu;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("พ๖");
        manager.b = y;
        manager.a = z;
        chok = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("มุ");
        manager.b = -1;
        manager.a = -1;
        chok = false;
    }

}
