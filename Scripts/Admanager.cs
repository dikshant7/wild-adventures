using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Admanager : MonoBehaviour //, IUnityAdsListener
{
    
    string  GameID="4153317";
    bool testmode=false;// false if game is live
    string VideoAd="Interstitial_Android";//1
    string VideoAd2="lvl1home";//2
    string VideoAd3="Lvl1DeathRetry";//3
    string VideoAd4="LvlCompletedRestart";//4
    string VideoAd5="Lvl1CompletedNextLvl";//5
    string VideoAd6="Lvl2PauseRetry";//6
    string VideoAd7="Lvl2pauseHome";//7
     string VideoAd8="Lvl2DeathHome";//8
  
    void Start()
    {
    
       Advertisement.Initialize(GameID,testmode);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayVideoads()// simple interstial add 1
    {
        if(Advertisement.IsReady(VideoAd))
        {
        Advertisement.Show(VideoAd);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
    public void DisplayVideoadslvl1home()// simple interstial add 2
    {
        if(Advertisement.IsReady(VideoAd2))
        {
        Advertisement.Show(VideoAd2);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
    public void Lvl1DeathRetry()// simple interstial add 3
    {
        if(Advertisement.IsReady(VideoAd3))
        {
        Advertisement.Show(VideoAd3);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
      public void LvlCompletedRestart()// simple interstial add 4
    {
        if(Advertisement.IsReady(VideoAd4))
        {
        Advertisement.Show(VideoAd4);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
      public void Lvl1CompletedNextLvl()// simple interstial add 5
    {
        if(Advertisement.IsReady(VideoAd5))
        {
        Advertisement.Show(VideoAd5);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
      public void Lvl2PauseRetry()// simple interstial add 6
    {
        if(Advertisement.IsReady(VideoAd6))
        {
        Advertisement.Show(VideoAd6);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
        public void Lvl2pauseHome()// simple interstial add 7
    {
        if(Advertisement.IsReady(VideoAd7))
        {
        Advertisement.Show(VideoAd7);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
        public void Lvl2DeathHome()// simple interstial add 8
    {
        if(Advertisement.IsReady(VideoAd8))
        {
        Advertisement.Show(VideoAd8);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
    
 

}
