using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishManager : MonoBehaviour
{   
    public static FinishManager instance;
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject LosePanel;
    private int BlocksOpened;

    private void Awake()
    {
        instance = this;
    }
    public void PlayerWon()
    {
        WinPanel.SetActive(true);
    }
    public void PlayerLost()
    {
        LosePanel.SetActive(true);
    }

    public void BlockOpened()
    {
        BlocksOpened++;
        if(BlocksOpened >= GridLayoutt.instance.GetBlocks().Length)
        {
            PlayerWon();
        }
    }
}
