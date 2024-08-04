using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOpener : MonoBehaviour
{
    [SerializeField] private GameObject[] LevelPrefabs;
    [SerializeField] private GameObject Canvas;
    [SerializeField] private Transform[] TenTenSpawn;
    [SerializeField] private GameObject UICanvas;





    public void OpenLevel(int a)
    {
        Instantiate(LevelPrefabs[a], TenTenSpawn[0]);
        Canvas.SetActive(false);
        UICanvas.SetActive(true);
    }
}
//public enum Spawns
//{
//    ten,
//    fifteen,
//    twenty,
//}
