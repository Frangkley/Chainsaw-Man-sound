using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 슈퍼광고 : MonoBehaviour {

    public string 전면광고ID = "ca-app-pub-8583528480029184/8226877757";
    public string 보상광고오리지널ID = "ca-app-pub-8583528480029184/1405236965";
    public string 보상광고공유ID = "ca-app-pub-8583528480029184/5292149699";
    public string 보상광고입장ID = "ca-app-pub-8583528480029184/6792841732";
    public string 현재이름;
    public float 시간체크 = 15f;
    public int Bu = 1;
    public Le번역의요정개인 번역의요정;
    public string 영문이름;
    public TextAsset 공유할음성;
    public int 공유할음성번호 = 0;
    public 소리재생스크립트 소리재생스크립;
    public bool 보상값 = false;
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
  //  const string rewardID = "ca-app-pub-8583528480029184/3062945328";
    private RewardedAd rewardedAd;
    private RewardedAd rewardedAdshare;
    private RewardedAd rewardeAdTip;
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
        공유리워드영상광고();
        즐겨찾기방입장광고();
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
    public void 음성공유광고보여줘(int 번호, Le번역의요정개인 ang)
    {
        if (rewardedAd.IsLoaded())
        {
            공유할음성번호 = 번호;
            rewardedAdshare.Show();
        }
        else
        {
            ang.광고실패창.SetActive(true);
            공유리워드영상광고();
        }
    }
    public void 무료로공유해드립니다(int 번호, Le번역의요정개인 ang)
    {
        공유할음성번호 = 번호;
        공유할음성 = 소리재생스크립.클립공유용들[공유할음성번호];
        string path = System.IO.Path.Combine(Application.temporaryCachePath, (영문이름 + " " + 공유할음성번호 + ".mp3"));
        System.IO.File.WriteAllBytes(path, 공유할음성.bytes);
        new NativeShare().AddFile(path).Share();
        보상값 = false;
    }
    public void 즐겨찾기방입장광고보여줘(게임매니저스크립 ang)
    {
        if (rewardeAdTip.IsLoaded())
        {
            rewardeAdTip.Show(); 
        }
        else
        {
            ang.즐겨찾기방광고실패팝업.SetActive(true);
            즐겨찾기방입장광고();
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
            if(!rewardedAdshare.IsLoaded())
            {
                공유리워드영상광고();
            }
            if(!rewardeAdTip.IsLoaded())
            {
                즐겨찾기방입장광고();
            }
        }
    }
    public void 리퀘스트영상광고()
    {
        this.rewardedAd = new RewardedAd(보상광고오리지널ID);
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;

        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }
    public void 공유리워드영상광고()
    {
        rewardedAdshare = new RewardedAd(보상광고공유ID);
        rewardedAdshare.OnUserEarnedReward += ShareHandleUserEarnedReward;
        rewardedAdshare.OnAdClosed += 보상을받았나요;
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAdshare.LoadAd(request);
    }
    public void 즐겨찾기방입장광고()
    {
       rewardeAdTip = new RewardedAd(보상광고입장ID);
        rewardeAdTip.OnUserEarnedReward += 즐겨찾기방입장리워드;
        AdRequest request = new AdRequest.Builder().Build();
        rewardeAdTip.LoadAd(request);
    }
    //private void OnAdClosed(object sender, EventArgs e)
    //{
    //    RequestInterstitialAds();
    //}
    public void ShowInterstitialAd()
    {
        if (DataBase.Instance().모드종류 == DataBase.프리미엄모드.프리미엄)
        {
            return;
        }
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
        string adID_2 = "ca-app-pub-8583528480029184/7329201811";

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

    /*
    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        
    }*/
    public void HandleUserEarnedReward(object sender, Reward args)
    {
        //케릭터단위일때
        /*
        Debug.Log("즐겨찾기 보상획득");
        PlayerPrefs.SetInt(현재이름, 1);
        Debug.Log(PlayerPrefs.GetInt(현재이름));
        */
        PlayerPrefs.SetInt("즐찾횟수", 2);
    }
    public void ShareHandleUserEarnedReward(object sender, Reward args)
    {
        보상값 = true;

    }
    public void 즐겨찾기방입장리워드(object sender, Reward args)
    {
        SceneManager.LoadScene("즐겨찾기방");
    }
    public void 보상을받았나요(object sender, EventArgs args)
    {
        if (보상값)
        {/*
            string 임시이름 = "name";
            if (PlayerPrefs.GetInt("EnKo") != 0)
            {
                임시이름 = 영문이름;
            }
            else
            {
                임시이름 = 현재이름;
            }*/
            
            공유할음성 = 소리재생스크립.클립공유용들[공유할음성번호];
            string path = System.IO.Path.Combine(Application.temporaryCachePath, (영문이름+" "+공유할음성번호+".mp3"));
            System.IO.File.WriteAllBytes(path, 공유할음성.bytes);
            new NativeShare().AddFile(path).Share();
            //Debug.Log("공유하기 권한획득");
            보상값 = false;
        }
    }
    #endregion

}
