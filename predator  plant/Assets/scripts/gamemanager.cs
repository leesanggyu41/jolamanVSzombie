using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEditor;

public class gamemanager : MonoBehaviour
{
    public TMP_Text moneytext;
    public int a, b, bunho, money;
    public GameObject[] posi = new GameObject[35];
    public tile[] tile = new tile[35];
    private string[] part;
    private int namea, nameb;
    public int remoney;
    public int n = -1, m = -1;
    public Slider round;
    public GameObject[] last;
    public GameObject clear;
    public zombiesp zombiesp;

    private void Update()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
        GameObject[] bosses = GameObject.FindGameObjectsWithTag("Boss");
        moneytext.text = Convert.ToString(money);
        if (round.value == 175)
        {
            zombiesp.cool = 100;
            foreach (GameObject obj in last)
            {

                obj.SetActive(true);
            } 
        }
        if (round.value == 180 && (zombies.Length == 0 && bosses.Length == 0))
        {
            clear.SetActive(true);
        }
    }
}
