using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class BannerAd : MonoBehaviour
{
    string  GameID="4153317";
    bool testmode=true;// false if game is live
    string BannerAD="Banner_Android";
    // Start is called before the first frame update
    void Start()
    {   Advertisement.Initialize(GameID,testmode);
        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);// to set banner add position
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //banner add starts
    IEnumerator ShowBannerWhenInitialized () {
         while (!Advertisement.isInitialized) {
            yield return new WaitForSeconds(0.5f);
         }
         Advertisement.Banner.Show (BannerAD);
     }
}
