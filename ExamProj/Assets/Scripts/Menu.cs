using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Menu_Panel;
    public GameObject Select_Level;
    public GameObject Title_Panel;
    public GameObject Control_Panel;
    public GameObject Credits_Panel;
    public static bool isPaused;

    public void SelectLevel()
    {
        Select_Level.SetActive(true);
        Control_Panel.SetActive(false);
        Credits_Panel.SetActive(false);
        Title_Panel.SetActive(false);

    }

    public void Control()
    {
        Select_Level.SetActive(false);
        Control_Panel.SetActive(true);
        Credits_Panel.SetActive(false);
        Title_Panel.SetActive(false);
    }
    public void MainMenu()
    {
        Select_Level.SetActive(false);
        Control_Panel.SetActive(false);
        Credits_Panel.SetActive(false);
        Title_Panel.SetActive(true);
    }

    public void Credits()
    {
        Select_Level.SetActive(false);
        Control_Panel.SetActive(false);
        Credits_Panel.SetActive(true);
        Title_Panel.SetActive(false);
    }

    public void Resume()
    {
        Menu_Panel.SetActive(false);
        Time.timeScale = 1;
        PlayerController.isPaused = false;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadTrainingLevel()
    {
        PlayerController.isPaused = false;
        PlayerController.isDead = false;
        SceneManager.LoadScene(1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel1()
    {
        PlayerController.isPaused = false;
        PlayerController.isDead = false;
        SceneManager.LoadScene(2);
    }
    public void LoadLevel2()
    {
        PlayerController.isPaused = false;
        PlayerController.isDead = false;
        SceneManager.LoadScene(3);
    }

    public void RestartLevel()
    {
        PlayerController.isDead = false;
        PlayerController.isPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false; // ‚ Unity
        Application.Quit(); // ‚ ·≥Î‰≥
    }
}
