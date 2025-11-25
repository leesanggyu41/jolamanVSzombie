using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class miner : MonoBehaviour
{
    public gamemanager manager;
    public int gold, HP;
    public AudioSource coin;
    
    
    private void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<gamemanager>();
        InvokeRepeating("mine",5,10);
        
    }
    void mine()
    {
        coin.Play();
        manager.money += gold;
    }
    


}
