using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdBanner : MonoBehaviour {
    private string UNIT_ID = "ca-app-pub-3940256099942544/6300978111";

    private BannerView banner;
    private void OnEnable() {
        if (SceneManager.GetActiveScene().name == "Workouts") {
            banner = new BannerView(UNIT_ID, AdSize.Banner, AdPosition.Bottom);
        }
        else {
            banner = new BannerView(UNIT_ID, AdSize.Banner, AdPosition.TopLeft);
        }
        AdRequest adRequest = new AdRequest.Builder().Build();
        banner.LoadAd(adRequest);
    }

    public void ShowAd() {
        banner.Show();
    }

    public void Start() {
        ShowAd();
    }
}
