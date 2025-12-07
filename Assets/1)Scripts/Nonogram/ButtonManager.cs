using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ModeText;
    public void Fill()
    {
        TouchManager.instance.SetTouchType(0);
        ModeText.text = "Fill";
    }
    public void Cross()
    {
        TouchManager.instance.SetTouchType(1);
        ModeText.text = "Cross";
    }
    public void Bonus()
    {
        TouchManager.instance.SetTouchType(2);
        ModeText.text = "Bonus";
    }

    public void SwitchScene(int a)
    {
        SceneManager.LoadScene(a);
    }



}
