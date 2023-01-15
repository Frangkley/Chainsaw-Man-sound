using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 슈퍼광고 : MonoBehaviour {
    public string 현재이름;
    public float 시간체크 = 15f;
    public int Bu = 1;
    public Le번역의요정개인 번역의요정;
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
    const string rewardID = "ca-app-pub-8583528480029184/3062945328";
    private RewardedAd rewardedAd;
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
        리퀘스트영상광고();
    }
    public void 즐겨찾기광고보여줘(string name, Le번역의요정개인 ang)
    {
        if (rewardedAd.IsLoaded())
        {
            현재이름 = name;
            rewardedAd.Show();
        }
        else
        {
            ang.광고실패창.SetActive(true);
            리퀘스트영상광고();
        }
    }
    public void Update()
    {
        시간체크 -= Time.deltaTime;
        if (시간체크 <= 0)
        {
            시간체크 = 10f;
            if(!rewardedAd.IsLoaded())
            {
                리퀘스트영상광고();
            }
        }
    }
    public void 리퀘스트영상광고()
    {
        this.rewardedAd = new RewardedAd("ca-app-pub-8583528480029184/1405236965");
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;

        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
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
        string adID_2 = "ca-app-pub-8583528480029184/8226877757";

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
    #region 리워드 광고


    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        
    }
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("즐겨찾기 보상획득");
        PlayerPrefs.SetInt(현재이름, 1);
        Debug.Log(PlayerPrefs.GetInt(현재이름));
    }

    #endregion
}
