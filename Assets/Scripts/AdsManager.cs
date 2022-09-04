using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class AdsManager : MonoBehaviour, IInterstitialAdListener, IPermissionGrantedListener{
    private const string APP_KEY = "0a6e670b2ced047f6f0e51541ab3d2bc0851749f088e2ac2";

    private void Start() {
        //Initialize(true);
        ShowBanner(true);
    }

    private void Awake() {
       // Appodeal.requestAndroidMPermissions(this);
    }
    private void Initialize(bool consentValue) {
        //Appodeal.setTesting(consentValue);
        Appodeal.muteVideosIfCallsMuted(true);
        Appodeal.disableLocationPermissionCheck();
        Appodeal.disableWriteExternalStoragePermissionCheck();
        Appodeal.initialize(APP_KEY, Appodeal.INTERSTITIAL, consentValue);
    }

    public void ShowInterstitial() {
        Random random = new Random();
        int count = random.Next(0, 6);
        if (count == 2 || count == 5) {
            if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
                Appodeal.show(Appodeal.INTERSTITIAL);  
        }
    }

    public void ShowBanner(bool consentValue) { //для нового дизайна - выбрала банеры
        Appodeal.setTesting(consentValue);
        Appodeal.initialize(APP_KEY, Appodeal.BANNER, consentValue);
        if (SceneManager.GetActiveScene().name == "Player") {
            Appodeal.show(Appodeal.BANNER_HORIZONTAL_SMART);
        }
        else {
            Appodeal.show(Appodeal.BANNER_BOTTOM);
        }
    }

    public void ShowNonSkippable() {
        if (Appodeal.canShow(Appodeal.NON_SKIPPABLE_VIDEO))
            Appodeal.show(Appodeal.INTERSTITIAL);
    }

    public IEnumerator IEShowNonSkippable() {
        yield return new WaitUntil(() => Appodeal.canShow(Appodeal.NON_SKIPPABLE_VIDEO));
        Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
    }
    public void onInterstitialClicked() {
        //пользователь кликнул на рекламу
    }

    public void onInterstitialClosed() {
        //реклама закрыта
    }

    public void onInterstitialExpired() {
        //срок действия рекламы истёк
    }

    public void onInterstitialLoaded(bool isPrecache) {
        //межстраничная реклама загружена
    }

    public void onInterstitialShown() {
        //реклама показана
    }

    public void onInterstitialShowFailed() {
        
    }

    public void onInterstitialFailedToLoad() {
        //ошибка при загрузке рекламы
    }
    
    public void writeExternalStorageResponse(int result) { 
        if(result == 0) {
            Debug.Log("WRITE_EXTERNAL_STORAGE permission granted"); 
        } else {
            Debug.Log("WRITE_EXTERNAL_STORAGE permission grant refused"); 
        }
    }
    public void accessCoarseLocationResponse(int result) { 
        if(result == 0) {
            Debug.Log("ACCESS_COARSE_LOCATION permission granted"); 
        } else {
            Debug.Log("ACCESS_COARSE_LOCATION permission grant refused"); 
        }
    }
}
