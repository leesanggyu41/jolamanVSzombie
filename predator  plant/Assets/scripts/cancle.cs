using UnityEngine;

public class cancle : MonoBehaviour
{
    public gamemanager manager;
    public GameObject tiles, canclebutten;
    public void can()
    {
        tiles.SetActive(false); 
        canclebutten.SetActive(false);
        manager.money += manager.remoney;
    }
}
