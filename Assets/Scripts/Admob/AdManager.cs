using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    private BannerView adBanner;
    private string idApp, idBanner;

    void Start()
    {
        idApp = "ca-app-pub-6717588109334744~9965556217";
        idBanner = "ca-app-pub-6717588109334744/7960718711";

        MobileAds.Initialize(idApp);
        RequestBannerAd();
    }

    public void RequestBannerAd()
    {
        adBanner = new BannerView(idBanner, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = AdRequestBuild();
        adBanner.LoadAd(request);
    }

    public void DestroyBannerAd()
    {
        if (adBanner != null)
            adBanner.Destroy();
    }

    AdRequest AdRequestBuild()
    {
        return new AdRequest.Builder().Build();

    }
}
