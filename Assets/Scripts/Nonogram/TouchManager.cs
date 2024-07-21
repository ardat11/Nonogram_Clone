using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchManager : MonoBehaviour
{  
    public static TouchManager instance;
    private bool isMouseDown = false;
    private TouchType touchType;

    private void Awake()
    {
        instance = this;
        touchType = TouchType.Fill;
    }

    

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            isMouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMouseDown = false;
        }
    }


    public bool GetIsMouseDown()
    {
        return isMouseDown; 
    }
    public void SetTouchType(int a)
    {
        touchType = (TouchType)a;
    }
    public int GetTouchType()
    {
        return (int)touchType;
    }





}
enum TouchType
{
    Fill,
    Cross,
    Bonus,
}
