using UnityEngine;

public class newClearsommon : MonoBehaviour
{
    public GameObject newclear;

    public void sommon()
    {
        newclear.SetActive(true);
        DeleteObjectsWithTag("Zombie");
        DeleteObjectsWithTag("Boss");
    }
    void DeleteObjectsWithTag(string tag)
    {
        // 태그로 모든 오브젝트 찾기
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);

        // 오브젝트 배열 순회하면서 삭제
        foreach (GameObject obj in objects)
        {
            Destroy(obj);  // 오브젝트 파괴
        }
    }
}
