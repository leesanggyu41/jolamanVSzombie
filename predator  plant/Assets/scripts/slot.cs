using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class slot : MonoBehaviour
{
    public GameObject tiles, cancle;
    public int bun;
    public gamemanager manager;
    public int cost;
    public float cool;
    public bool um;
   public void click()
   {
        if (tiles.active == false)
        {
            if (!um)
            {
                if (manager.money >= cost)
                {

                    manager.money -= cost;
                    manager.remoney = cost;
                    tiles.SetActive(true);
                    cancle.SetActive(true);
                    manager.bunho = bun;
                }
            }
        }
   }
}
