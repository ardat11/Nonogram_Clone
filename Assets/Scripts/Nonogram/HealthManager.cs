using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{   
    public static HealthManager Instance;
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;
    [SerializeField] private int health =3;
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private TMP_Text losescore;

    private void Awake()
    {
        Instance = this;
    }



    public void DecreaseHealth()
    {
        health--;
        if (health == 2)
        {
            Heart3.enabled = false;
        }
        else if (health == 1)
        {
            Heart2.enabled = false;
        }
        else if (health == 0)
        {
            Heart1.enabled = false;
            //Time.timeScale = 0;
            FinishManager.instance.PlayerLost();
        }
    }

}