using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 다운링크본인 : MonoBehaviour
{
    public string 한글링크 = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public string 영어링크 = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public GameObject 본인닫기;
    // Start is called before the first frame update
    public void 팝업켜기()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            Application.OpenURL(영어링크);
        }
        else
        {
            Application.OpenURL(한글링크);
        }
    }
}
