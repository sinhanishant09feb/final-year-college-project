using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void onLoad0()
    {
        SceneManager.LoadScene(0);
    }

    public void onLoad1()
    {
        SceneManager.LoadScene(1);
    }

    public void onLoad2()
    {
        SceneManager.LoadScene(2);
    }

    public void onExit()
    {
        Application.Quit();
    }
}
