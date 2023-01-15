using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 메인전용 : MonoBehaviour {
    

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

        if (n <= 50)
        {
            슈퍼광고.Instance().ShowInterstitialAd();

        }
    }
}

