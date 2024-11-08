﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
public class 배너광고 : MonoBehaviour
{
    public string 배너광고ID = "ca-app-pub-8583528480029184/6318899712";
    public static 배너광고 instance;
    public static 배너광고 Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<배너광고>();

            if (instance == null)
            {
                GameObject container = new GameObject("Bena");

                instance = container.AddComponent<배너광고>();
            }
        }
        return instance;
    }
    //static bool isAdsBannerSet = false;
    private BannerView bannerView;
    public void Start()
    {
        if (DataBase.Instance().모드종류 == DataBase.프리미엄모드.일반)
        {
            ShowBannerAd();
        }
    }
    public void 숨기자()
    {
        if (bannerView != null)
        {
            bannerView.Destroy();
        }
    }
    private void ShowBannerAd()
    {
        //string adID = "ca-app-pub-8583528480029184/4972626904";
        //bannerView = new BannerView(adID, AdSize.SmartBanner, AdPosition.Top);
        //AdRequest request = new AdRequest.Builder().Build();
        //bannerView.LoadAd(request);
        //string adID = "ca-app-pub-8583528480029184/5308693078";
        // AdSize adSize = new AdSize(300, 30);
        /*BannerView*/
        //AdSize.Banner
        bannerView = new BannerView(배너광고ID, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
        bannerView.Show();
      //  isAdsBannerSet = true;
        // BannerView _banner = new BannerView(adID, AdSize.Banner, AdPosition.Bottom);
    }

    //public void OnDestroy()
    //{
    //    bannerView.Destroy();
    //}
}
