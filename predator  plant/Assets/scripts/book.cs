using UnityEngine;

public class book : MonoBehaviour
{
    public GameObject mine,gun,sh,sna,bo;
    public GameObject dogam;

    public void mi()
    {
        gun.SetActive(false);
        sh.SetActive(false); 
        sna.SetActive(false);
        bo.SetActive(false);
        mine.SetActive(true);
    }
    public void gu()
    {
        gun.SetActive(true);
        sh.SetActive(false);
        sna.SetActive(false);
        bo.SetActive(false);
        mine.SetActive(false);
    }
    public void shi()
    {
        gun.SetActive(false);
        sh.SetActive(true);
        sna.SetActive(false);
        bo.SetActive(false);
        mine.SetActive(false);
    }
    public void snai()
    {
        gun.SetActive(false);
        sh.SetActive(false);
        sna.SetActive(true);
        bo.SetActive(false);
        mine.SetActive(false);
    }
    public void boom()
    {
        gun.SetActive(false);
        sh.SetActive(false);
        sna.SetActive(false);
        bo.SetActive(true);
        mine.SetActive(false);
    }
    public void can()
    {
        dogam.SetActive(false);
    }
}
