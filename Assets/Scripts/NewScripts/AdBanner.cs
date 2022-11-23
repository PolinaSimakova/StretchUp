using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;


public class AdBanner : MonoBehaviour
{
    private BannerView bannerView;
    private void Start() {
        MobileAds.Initialize(status => { });
        RequestBanner();
    }
    
    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitIdBannerTest = "ca-app-pub-3940256099942544/6300978111";
      //  string adUnitIdBanner = "ca-app-pub-5684932031961846/8696513635";
#elif UNITY_IPHONE
            string adUnitIdBanner  = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitIdBanner  = "unexpected_platform";
#endif

        if (SceneManager.GetActiveScene().name == "Workouts") {

            bannerView = new BannerView(adUnitIdBannerTest , AdSize.SmartBanner, AdPosition.Bottom);
        } else if (SceneManager.GetActiveScene().name == "Player") {

            bannerView = new BannerView(adUnitIdBannerTest ,  AdSize.Banner, AdPosition.TopLeft);
        }
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
    
    void OnDestroy() {
        bannerView.Destroy();
    }
}
