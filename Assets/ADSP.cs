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
    private BannerView ��ʺ�;
    private InterstitialAd ����;
    public GameObject ���ƴ�;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initSatus => { });
        this.������Ʈ���();
        ������Ʈ����();
    }
    public void ������Ʈ���()
    {
       // adUnitId = "ca-app-pub-3940256099942544/6300978111";
        adUnitId = "ca-app-pub-8583528480029184/1635391745";
        if (this.��ʺ� != null)
        {
            this.��ʺ�.Destroy();
        }
        ��ʺ� = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        ��ʺ�.LoadAd(request);
        ��ʺ�.Show();
    }
    public void ������2()
    {
        if (this.��ʺ� != null)
        {
            this.��ʺ�.Destroy();
        }
    }
    public void ������Ʈ����()
    {
        adUnitId = "ca-app-pub-8583528480029184/3158041189";
        // adUnitId = "ca-app-pub-3940256099942544/1033173712";
        this.���� = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        ����.LoadAd(request);
    }
    public void �����ֱ�()
    {
        if (����.IsLoaded())
        {
            ����.Show();
        }
        else
        {
            print("�ε尡 �ȵ̾�");
        }
    }
}
