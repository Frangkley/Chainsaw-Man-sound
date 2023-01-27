using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 메인전용 : MonoBehaviour
{

    public string 한글링크 = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public string 영어링크 = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public GameObject 리뷰한글팝업창;
    public GameObject 리뷰영어팝업창;

    public void 다운링크리뷰전용()
    {
        int i = PlayerPrefs.GetInt("즐찾횟수");
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            Application.OpenURL(영어링크);
            리뷰영어팝업창.SetActive(false);
        }
        else
        {
            Application.OpenURL(한글링크);
            리뷰한글팝업창.SetActive(false);
        }

        PlayerPrefs.SetInt("즐찾횟수", i + 5);

    }
    void Start()
    {
        되냐();
    }
    public void 되냐()
    {
        int A = 슈퍼광고.Instance().Bu;
        if (A != 0)
        {
            슈퍼광고.Instance().Bu -= 1;
            return;

        }
        int n = Random.Range(0, 100);
        int i = PlayerPrefs.GetInt("리뷰");
        if (i < 10)
        {
            if (n <= 30)
            {
                슈퍼광고.Instance().ShowInterstitialAd();
            }
            else
            {
                PlayerPrefs.SetInt("리뷰", i + 1);
                if (PlayerPrefs.GetInt("리뷰") == 10)
                {
                    if (PlayerPrefs.GetInt("EnKo") != 0)
                    {
                        리뷰영어팝업창.SetActive(true);
                    }
                    else
                    {
                        리뷰영어팝업창.SetActive(true);
                    }
                }
            }
        }
        else
        {
            if (n <= 40)
            {
                슈퍼광고.Instance().ShowInterstitialAd();

            }
            else
            {
                PlayerPrefs.SetInt("리뷰", i + 1);
                if (PlayerPrefs.GetInt("리뷰") == 10)
                {
                    if (PlayerPrefs.GetInt("EnKo") != 0)
                    {
                        리뷰영어팝업창.SetActive(true);
                    }
                    else
                    {
                        리뷰영어팝업창.SetActive(true);
                    }
                }
            }
        }
    }
}

