using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BonusManager : MonoBehaviour
{
    public static BonusManager instance;

    [SerializeField] private int Bonus;
    [SerializeField] private TMP_Text ButtonText;

    private void Awake()
    {
        instance = this;
        
    }
    private void Start()
    {
        ButtonText.text = "Bonus: "+ Bonus;
    }


    public void DecreaseBonus()
    {
        Bonus--;
        ButtonText.text = "Bonus: " + Bonus;
        if(Bonus <= 0 ) 
        {
            Button button = GetComponent<Button>();
            button.enabled = false;
            ButtonManager manager = transform.parent.GetComponent<ButtonManager>();
            manager.Fill();
        }

    }
}
