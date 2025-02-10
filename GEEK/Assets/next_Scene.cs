using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_Scene : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Options;
    public void ContinueBtn()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenOptions()
    {
        Menu.SetActive(false);
        Options.SetActive(true);
    }
    public void CloseOptions()
    {
        Menu.SetActive(true);
        Options.SetActive(false);
    }
}
