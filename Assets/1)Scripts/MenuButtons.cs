using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void SwitchScene(int a)
    {
        SceneManager.LoadScene(a);
    }
}
