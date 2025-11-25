using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bvl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text te;

    public void OnPointerEnter(PointerEventData eventData)
    {
        te.color = Color.black;
        te.rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        te.color = Color.white;
        te.rectTransform.localScale = new Vector3(1f, 1f, 1f);
    }
}
