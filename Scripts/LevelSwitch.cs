using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour
{
     public void levels(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
        Debug.Log("CLicked");
    }
}
