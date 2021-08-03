using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManagerLvl1 : MonoBehaviour , IUnityAdsListener
{
    
    string  GameID="4153317";
    bool testmode=true;// false if game is live
    string VideoAd="Interstitial_Android";
    string RewardedAd="Rewarded_Android";
    string BannerAD="Banner_Android";
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener (this);
       Advertisement.Initialize(GameID,testmode);
       StartCoroutine(ShowBannerWhenInitialized());
       Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);// to set banner add position
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayVideoads()// simple interstial add
    {
        if(Advertisement.IsReady(VideoAd))
        {
        Advertisement.Show(VideoAd);
        }
        else{
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }
    //over inteestial adds
    public void ShowRewardedVideo() {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(RewardedAd)) {
            Advertisement.Show(RewardedAd);
        } 
        else {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish (string surfacingId, ShowResult showResult) {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished) {
            // Reward the user for watching the ad to completion.
        } else if (showResult == ShowResult.Skipped) {
            // Do not reward the user for skipping the ad.
        } else if (showResult == ShowResult.Failed) {
            Debug.LogWarning ("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady (string surfacingId) {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == RewardedAd) {
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError (string message) {
        // Log the error.
    }

    public void OnUnityAdsDidStart (string surfacingId) {
        // Optional actions to take when the end-users triggers an ad.
    } 

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy() {
        Advertisement.RemoveListener(this);
    }
    // rewarded ads script over
    //banner add starts
    IEnumerator ShowBannerWhenInitialized () {
        while (!Advertisement.isInitialized) {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show (BannerAD);
    }
}
