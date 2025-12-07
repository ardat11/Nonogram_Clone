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
    private int truecount;

    private void Start()
    {
        Blocks = GridLayoutt.instance.GetBlocks();
        System.Array.Resize(ref hizaliblocks, Blocks.Length);
        text.text = null;

        if(Line == Line.dikey)
        {
            for(int i = 0; i < Blocks.Length; i++) 
            {
                if (Mathf.Approximately(Blocks[i].transform.position.x, transform.position.x)) 
                {
                    hizaliblocks[k] = Blocks[i];
                    ResRevealer revealer = hizaliblocks[k].GetComponent<ResRevealer>();
                    revealer.Fillers.Add(this);
                    k++;
                }
            }

        }
        else
        {
            for (int i = 0; i < Blocks.Length; i++) 
            {
                if (Mathf.Approximately(Blocks[i].transform.position.y, transform.position.y)) 
                {
                    hizaliblocks[k] = Blocks[i];
                    ResRevealer revealer = hizaliblocks[k].GetComponent<ResRevealer>();
                    revealer.Fillers.Add(this);
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
    public void SetCheck()
    {
        print("SetCheckk");
        for (int i = 0; i < hizaliblocks.Length; i++)
        {
            ResRevealer Block = hizaliblocks[i].GetComponent<ResRevealer>();
            if (Block.GetIsFilled() && Block.GetRevealed())
            {
                truecount++;
            }
            if (truecount == SumArray(ints))
            {
                RevealAll();
                break;
            }
            

        }
        truecount = 0;
    }

    public void RevealAll()
    {
        for(int i = 0; i < hizaliblocks.Length; i++)
        {
            ResRevealer Block = hizaliblocks[i].GetComponent<ResRevealer>();
            if (!Block.GetRevealed())
            {
                Block.Reveal();
            }
        }
    }
    private int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
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
    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.V))
    //    {
    //        SetCheck();
    //    }
    //}
}



public enum Line
{
    yatay,
    dikey,
}
