using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResRevealer : MonoBehaviour
{
    public bool isFilled;
    [SerializeField] private SpriteRenderer render;
    [SerializeField] private Material[] colors;

    private void Awake()
    {
        int i = Random.Range(0, 2);
        if(i == 0)
        {
            isFilled = false;
        }
        else
        {
            isFilled = true;
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
        if(isFilled)
        {   
            render.sharedMaterial = colors[0];
            if(TouchManager.instance.GetTouchType() ==1)
            {
                HealthManager.Instance.DecreaseHealth();
            }
            FinishManager.instance.BlockOpened();
        }
        else
        {
            render.sharedMaterial = colors[1];
            if (TouchManager.instance.GetTouchType() == 0)
            {
                HealthManager.Instance.DecreaseHealth();
            }
            FinishManager.instance.BlockOpened();
        }

    }
}
