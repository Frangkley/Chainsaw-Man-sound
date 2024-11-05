using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
public class C4 : MonoBehaviour
{
    void Start()
    {
            Invoke("삭제용", 0.3f);
    }

    public void 삭제용()
    {
        SceneManager.LoadScene("메인");
    }
}
