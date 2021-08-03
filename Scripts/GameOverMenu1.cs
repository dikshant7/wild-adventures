using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverMenu1 : MonoBehaviour
{
   
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
    public void NextLevel()
    {
         if(SceneManager.GetActiveScene().buildIndex == 5) /* < Change this int value to whatever your
                                                                   last level build index is on your
                                                                   build settings */
            {
                Debug.Log("You Completed ALL Levels");
                
                //Show Win Screen or Somethin.
            }
            else
            {
                int nextSceneLoad= SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneLoad);
                //Setting Int for Index
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
    }
      
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
