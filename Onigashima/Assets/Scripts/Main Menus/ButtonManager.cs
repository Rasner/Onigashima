using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private void Start()
    {

    }
    public void NewGame()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ReturMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Retry()
    {

    }
    public void Credits()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Ajustes()
    {
        SceneManager.LoadScene("Ajustes");
    }
    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
}

