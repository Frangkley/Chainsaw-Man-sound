using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 영한인식더보기팝업 : MonoBehaviour
{
    public GameObject 영어팝업;
    public GameObject 한글팝업;
    // Start is called before the first frame update

    public void 팝업켜기()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            영어팝업.SetActive(true);
          
        }
        else
        {
            한글팝업.SetActive(true);
        }
    }
}
