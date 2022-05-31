using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    [SerializeField] string _androidAdUnitIdInterstitial = "Interstitial_Android";
    [SerializeField] string _iOSAdUnitIdInterstitial = "Interstitial_iOS";
    [SerializeField] string _androidAdUnitIdBanner = "Banner_Android";
    [SerializeField] string _iOSAdUnitIdBanner = "Banner_iOS";
    
    private string _adUnitIdBanner;
    private string _adUnitIdInterstitial;
    private string _gameId;

    private static int wins = 0;
    private static int deaths = 0;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Awake()
    {
        InitializeAds();
        InitializeInterstitial();
        InitializeBanner();
    }

    #region INICIALIZAÇÃO
    private void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, Debug.isDebugBuild, this);
    }

    private void InitializeInterstitial()
    {
        _adUnitIdInterstitial = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSAdUnitIdInterstitial
            : _androidAdUnitIdInterstitial;
    }

    private void InitializeBanner()
    {
        _adUnitIdBanner = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSAdUnitIdBanner
            : _androidAdUnitIdBanner;
    }
    #endregion

    #region INTERSTITIAL
    public void LoadAdInterstitial()
    {
        Debug.Log("Loading Ad: " + _adUnitIdInterstitial);
        Advertisement.Load(_adUnitIdInterstitial);
    }

    public void ShowAdInterstitial()
    {
        Debug.Log("Showing Ad: " + _adUnitIdInterstitial);
        Advertisement.Show(_adUnitIdInterstitial);
    }
    #endregion

    #region BANNER
    public void LoadAdBanner()
    {
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Load(_adUnitIdBanner);
        if(Advertisement.Banner.isLoaded) Advertisement.Banner.Show(_adUnitIdBanner);
    }

    public void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }
    #endregion

    #region CONTADORES
    public int GetWinCounter()
    {
        return wins;
    }

    public int GetDeathCounter()
    {
        return deaths;
    }

    public void CounterWins(bool reset)
    {
        if(!reset)
        {
            wins++;
        }
        else
        {
            wins = 0;
        }
    }

    public void CounterDeaths(bool reset)
    {
        if (!reset)
        {
            deaths++;
        }
        else
        {
            deaths = 0;
        }
    }
    #endregion

    #region BIBLIOTECA INTERFACES
    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error Show Ad Unit: {placementId} - {error.ToString()} - {message}");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {placementId} - {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string placementId){}

    public void OnUnityAdsShowClick(string placementId){}

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState){}

    public void OnUnityAdsAdLoaded(string placementId){}
    #endregion
}
