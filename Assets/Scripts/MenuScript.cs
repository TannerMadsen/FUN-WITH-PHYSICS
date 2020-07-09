using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string MenuScene;
    public string PlayScene;
    public GameObject MainScreen;
    public GameObject InfoScreen;
    
    public void QuitToMainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene(MenuScene);
    }
    public void PlayGame(){
        Time.timeScale = 0;
        SceneManager.LoadScene(PlayScene);
    }
    public void TotalQuit(){
        Application.Quit();
    }
    public void ShowInfo(){
        MainScreen.SetActive(false);
        InfoScreen.SetActive(true);
    }
    public void BackToMenu(){
        MainScreen.SetActive(true);
        InfoScreen.SetActive(false);

    }

}
