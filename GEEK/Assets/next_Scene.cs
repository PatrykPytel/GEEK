using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_Scene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
