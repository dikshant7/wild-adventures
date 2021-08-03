using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        
        
    }
    public void Mute()
    {
        AudioListener.pause=true;
    }
     public void UnMute()
    {
        AudioListener.pause=false;
    }
    public void MainMenuSelect()
    {
         SceneManager.LoadScene(0);
    }
}
