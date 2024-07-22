using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public class ResRevealer : MonoBehaviour
{
    public bool isFilled;
    public bool RANDOMCREATION;
    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Material[] colors;
    private bool Revealed;
    public List<FillDecider> Fillers;
    private void Awake()
    {
        if (RANDOMCREATION)
        {
            int i = Random.Range(0, 2);
            if (i == 0)
            {
                isFilled = false;
            }
            else
            {
                isFilled = true;
            }
        }
        
    }

    public void SetIsFilled(bool a)
    {
        isFilled = a;
    }
    public bool GetIsFilled()
    {
        return isFilled;
    }

    public void Reveal()
    {   
        StackTrace stackTrace = new StackTrace();
        MethodBase caller = stackTrace.GetFrame(1).GetMethod();
        string callerName = caller.Name;
        
        if(isFilled)
        {   
            render.sharedMaterial = colors[0];
            if(TouchManager.instance.GetTouchType() ==1 && callerName == "OnMouseOver")
            {
                HealthManager.Instance.DecreaseHealth();
            }
            FinishManager.instance.BlockOpened();
        }
        else
        {
            render.sharedMaterial = colors[1];
            if (TouchManager.instance.GetTouchType() == 0 && callerName == "OnMouseOver")
            {
                HealthManager.Instance.DecreaseHealth();
            }
            FinishManager.instance.BlockOpened();
        }
        Revealed = true;
        CallForReveal();


    }
    private void CallForReveal()
    {
        Fillers[0].SetCheck();
        Fillers[1].SetCheck();
    }

    public bool GetRevealed()
    {
        return Revealed;
    }
}
