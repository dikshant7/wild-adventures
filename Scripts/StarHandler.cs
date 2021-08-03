using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarHandler : MonoBehaviour
{
    public GameObject[] stars;
    //public Text timer;
    private int coinsCounter;
    private int chestCounter;
    
    void Start()
    {
        
        coinsCounter=GameObject.FindGameObjectsWithTag("coin").Length;
        chestCounter=GameObject.FindGameObjectsWithTag("chest").Length;
    }
    public void starsCollected()
    {
        int coinsLeft=GameObject.FindGameObjectsWithTag("coin").Length;
        int coinsCollected=coinsCounter-coinsLeft;
        float percentage1= float.Parse(coinsCollected.ToString())/float.Parse(coinsCounter.ToString())*100f;
        int chestLeft=GameObject.FindGameObjectsWithTag("chest").Length;
         int chestCollected=chestCounter-chestLeft;
        float percentage2= float.Parse(chestCollected.ToString())/float.Parse(chestCounter.ToString())*100f;
        
        if(percentage1==100f&&percentage2==100f)
        {
              stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
        }

         else if((percentage1>=50f && percentage1<100f && percentage2==100f) ||( percentage1==100f && percentage2!=100f))
        {
             stars[0].SetActive(true);
            stars[1].SetActive(true);
             
        }
        else if((percentage1>=50f && percentage1<100f )|| (percentage2==100f))
        {
            stars[0].SetActive(true);
             
        }
       
       
    }
}