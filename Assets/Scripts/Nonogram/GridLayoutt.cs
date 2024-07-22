using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class GridLayoutt : MonoBehaviour
{
    public static GridLayoutt instance;

    [SerializeField] private bool GRIDCREATOR;

    [SerializeField] private GameObject NodePrefab;
    [SerializeField] private GameObject TextWriter;
    [SerializeField] private int yatay;
    [SerializeField] private int dikey;
    [SerializeField] private GameObject[] Blocks;
    private int i;
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {   
        System.Array.Resize(ref Blocks, yatay*dikey);
        if (GRIDCREATOR)
        {
            for (int x = 0; x <= yatay; x++)
            {
                for (int y = dikey; y >= 0; y--)
                {
                    Vector3 diff = new Vector3(x * NodePrefab.transform.localScale.x, y * NodePrefab.transform.localScale.y, 0);
                    if (x == 0 && y == dikey)
                    {
                        // Bilerek Boþ.
                    }
                    else if (diff.x == 0 || diff.y == dikey)
                    {
                        GameObject writer = Instantiate(TextWriter, transform.position + diff, Quaternion.identity, transform);
                        FillDecider write = writer.GetComponent<FillDecider>();
                        if (diff.y == dikey)
                        {
                            write.Line = Line.dikey;
                        }
                    }
                    else
                    {
                        GameObject block = Instantiate(NodePrefab, transform.position + diff, Quaternion.identity, transform);
                        Blocks[i] = block;
                        i++;
                    }
                }
            }
        }
        print("Bitti");

    }
    public GameObject[] GetBlocks()
    {
        return Blocks;
    }
    
    
    
    
    
    
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position + new Vector3(yatay / 2, dikey / 2, 0), new Vector3(yatay+1, dikey+1, 0));
    }
    
}
