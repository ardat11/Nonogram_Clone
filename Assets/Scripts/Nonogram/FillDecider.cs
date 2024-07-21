using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class FillDecider : MonoBehaviour
{
    public Line Line;
    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private GameObject[] Blocks;
    private GameObject[] hizaliblocks;
    private int k;
    [SerializeField] private int[] ints;
    private int spaces;
    [SerializeField] private TMP_Text text;
    private string lastEvent;

    private void Start()
    {
        Blocks = GridLayoutt.instance.GetBlocks();
        System.Array.Resize(ref hizaliblocks, Blocks.Length);
        text.text = null;

        if(Line == Line.dikey)
        {
            for(int i = 0; i < Blocks.Length; i++) //taranan bloklar
            {
                if (Blocks[i].transform.position.x == transform.position.x) // ayný hizada ise
                {
                    hizaliblocks[k] = Blocks[i];
                    k++;
                }
            }

        }
        else
        {
            for (int i = 0; i < Blocks.Length; i++) //taranan bloklar
            {
                if (Blocks[i].transform.position.y == transform.position.y) // ayný hizada ise
                {
                    hizaliblocks[k] = Blocks[i];
                    k++;
                }
            }
        }
        ListShorten();
        ListShortenint();
        for(int i = 0;  i < hizaliblocks.Length; i++)
        {
            ResRevealer block = hizaliblocks[i].GetComponent<ResRevealer>();
            print("Dogruluk degeri:" + block.GetIsFilled());
            if(block.GetIsFilled())
            {
                
                ints[spaces]++;
                lastEvent = "Add";
                if(i == hizaliblocks.Length -1)
                {
                    text.text += ints[spaces];
                }
                
            }
            else
            {
                if (lastEvent != "space")
                {
                    if (ints[spaces] != 0)
                    {
                        text.text += ints[spaces] + " ";

                        lastEvent = "space";
                        spaces++;
                    }
                }
                
            }
        }

    }

    private void ListShorten()
    {
        for (int i = 0; i < hizaliblocks.Length; i++)
        {
            if (hizaliblocks[i] == null)
            {
                System.Array.Resize(ref  hizaliblocks, i);
            }
        }
    }
    private void ListShortenint()
    {
        for (int i = 0; i < hizaliblocks.Length; i++)
        {
            if (hizaliblocks[i] == null)
            {
                System.Array.Resize(ref hizaliblocks, i);
            }
        }
    }
}



public enum Line
{
    yatay,
    dikey,
}
