using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelcompleted1 : MonoBehaviour
{
    public Text pointstext;
    // Start is called before the first frame updatepublic Text pointstext;
    public void Setup (int score)
    {
        gameObject.SetActive(true);
        pointstext.text=score.ToString()+"POINTS";
    }
}
