using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame(){
        Debug.Log("Oyundan ��kt�k!!");
        Application.Quit();
    }
    public void ReturnToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void ReGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
