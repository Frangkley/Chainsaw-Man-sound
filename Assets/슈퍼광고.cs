using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 슈퍼광고 : MonoBehaviour {

    public int Bu = 1;
    public static 슈퍼광고 instance;
    public static 슈퍼광고 Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<슈퍼광고>();

            if (instance == null)
            {
                GameObject container = new GameObject("GanggoCH");

                instance = container.AddComponent<슈퍼광고>();
            }
        }
        return instance;
    }
    private InterstitialAd interstitial;
    //private string adUnitId = "ca-app-pub-8583528480029184/3007565273";
    // Use this for initialization
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {
        //interstitial.OnAdClosed += OnAdClosed;
        RequestInterstitialAds();
    }
    //private void OnAdClosed(object sender, EventArgs e)
    //{
    //    RequestInterstitialAds();
    //}
    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
        else
        {
            RequestInterstitialAds();
        }

    }
    public void 로딩확인()
    {
        if (!interstitial.IsLoaded())
        {
            RequestInterstitialAds();
        }

    }
    private void RequestInterstitialAds()
    {
        string adID_2 = "ca-app-pub-8583528480029184/3158041189";

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adID_2);

        /*  //***Test***
          AdRequest request = new AdRequest.Builder()
         .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
         .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
         .Build();*/


        AdRequest request = new AdRequest.Builder().Build();


        // Load the interstitial with the request.
        interstitial.LoadAd(request);

    }
}
