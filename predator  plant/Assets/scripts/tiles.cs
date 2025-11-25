using System;
using UnityEngine;

public class tiles : MonoBehaviour
{
    public gamemanager manager;
    public GameObject[] cooltime;
    private string names;
    public GameObject target, tilee, can;
    public GameObject[] zolaman = new GameObject[5];
    public www cu;

    private void Update()
    {
        names = Convert.ToString(manager.a) + "," + Convert.ToString(manager.b);
    }
    public void onclick()
    {
        if (cu.y == cu.x)
        {
            target = GameObject.Find(names);
            foreach (Transform child in target.transform)
            {
                Destroy(child.gameObject);
            }
            tilee.SetActive(false);
            cu.y = null;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
        else
        {
            target = GameObject.Find(names);
            if (target.transform.childCount > 0)
            {
                tilee.SetActive(false);
                can.SetActive(false);
                manager.money += manager.remoney;
            }
            else
            {

                // 프리팹을 인스턴스화하여 새로운 게임 오브젝트 생성
                GameObject instantiatedPrefab = Instantiate(zolaman[manager.bunho]);

                // 인스턴스화된 프리팹을 부모 오브젝트의 자식으로 설정
                instantiatedPrefab.transform.SetParent(target.transform);

                // 자식 오브젝트의 로컬 위치를 초기화 (부모와 동일한 위치로 설정)
                instantiatedPrefab.transform.localPosition = Vector3.zero;

                // 자식 오브젝트의 로컬 회전도 초기화 (부모와 동일한 회전으로 설정)
                instantiatedPrefab.transform.localRotation = Quaternion.identity;
                

                tilee.SetActive(false);
                can.SetActive(false);
                cooltime[manager.bunho].SetActive(true);
                
            }
        }

    }
}
