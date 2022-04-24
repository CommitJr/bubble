using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour
{
    #region SCOPE
    public static Admob Instance;
    private BannerView bannerView;
    private InterstitialAd interstitial;
    #endregion

    #region START
    void Start()
    {
        MobileAds.Initialize(initStatus => { });

        this.RequestBanner();
        this.RequestInterstitial();
    }
    #endregion

    #region AWAKE
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    #region BANNER
    public void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = adUnitIdAndroid == "" ? "ca-app-pub-3940256099942544/6300978111" : adUnitIdAndroid;
        #elif UNITY_IPHONE
            string adUnitId = adUnitIdIphone == "" ? "ca-app-pub-3940256099942544/2934735716" : adUnitIphone;
        #else
            string adUnitId = "unexpected_platform";
        #endif

        this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(request);
    }

    void DestroyBanner()
    {
        this.bannerView.Destroy();
    }
    #endregion

    #region INTERSTITIAL
    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        this.interstitial = new InterstitialAd(adUnitId);

        this.interstitial.OnAdClosed += HandleOnAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        
        this.interstitial.LoadAd(request);
    }

    public void ShowInterstitial()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

    void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        this.RequestInterstitial();
    }
    #endregion
}
