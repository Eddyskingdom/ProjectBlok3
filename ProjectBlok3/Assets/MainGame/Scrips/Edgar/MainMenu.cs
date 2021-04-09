using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Panel;
    public int ChangeToScene = 1;
    public bool Reset = false;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    public void ChangeScene()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + ChangeToScene);
    }
    public void hasQuite()
    {
        Debug.Log("QUITE");
        Application.Quit();
    }

    public void Restart()
    {
        EditorSceneManager.LoadScene(ChangeToScene);
        Reset = true;

    }
}
