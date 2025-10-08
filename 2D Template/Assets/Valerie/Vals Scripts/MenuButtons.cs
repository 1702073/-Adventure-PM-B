using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Sample Scene");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}