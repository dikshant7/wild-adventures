using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverscreen1 : MonoBehaviour
{
    public Text pointstext;
    public void Setup (int score)
    {
        gameObject.SetActive(true);
        pointstext.text=score.ToString()+"POINTS";
    }
}
