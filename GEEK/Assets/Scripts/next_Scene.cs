using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_Scene : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Options;
    public GameObject controls;
    private float cooldown= 2f;
    void Cooldown()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void ContinueBtn()
    {
        Menu.GetComponent<Fade>().fadeOut = true;
        Invoke("Cooldown", cooldown);
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
    public void OpenControls()
    {
        Menu.SetActive(false);
        Options.SetActive(false);
        controls.SetActive(true);
    }
    public void CloseControls()
    {
        Menu.SetActive(false);
        Options.SetActive(true);
        controls.SetActive(false);
    }
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
