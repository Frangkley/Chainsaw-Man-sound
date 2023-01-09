using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class ADSP : MonoBehaviour
{
    public static ADSP instance;
    public static ADSP Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<ADSP>();

            if (instance == null)
            {
                GameObject container = new GameObject("Bena");

                instance = container.AddComponent<ADSP>();
            }
        }
        return instance;
    }
    string adUnitId;
    private BannerView 배너뷰;
    private InterstitialAd 전면;
    public GameObject 뉴아님;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initSatus => { });
        this.리퀘스트배너();
        리퀘스트전면();
    }
    public void 리퀘스트배너()
    {
       // adUnitId = "ca-app-pub-3940256099942544/6300978111";
        adUnitId = "ca-app-pub-8583528480029184/1635391745";
        if (this.배너뷰 != null)
        {
            this.배너뷰.Destroy();
        }
        배너뷰 = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        배너뷰.LoadAd(request);
        배너뷰.Show();
    }
    public void 숨기자2()
    {
        if (this.배너뷰 != null)
        {
            this.배너뷰.Destroy();
        }
    }
    public void 리퀘스트전면()
    {
        adUnitId = "ca-app-pub-8583528480029184/3158041189";
        // adUnitId = "ca-app-pub-3940256099942544/1033173712";
        this.전면 = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        전면.LoadAd(request);
    }
    public void 보여주기()
    {
        if (전면.IsLoaded())
        {
            전면.Show();
        }
        else
        {
            print("로드가 안됫어");
        }
    }
}
