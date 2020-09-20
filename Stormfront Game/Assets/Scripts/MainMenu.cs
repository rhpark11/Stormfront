using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void loadAScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
