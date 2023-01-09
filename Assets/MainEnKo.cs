using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public int 저장값 = 0;
    public Text 덴지버튼;
    public Text 마키마버튼;
    public Text 아키버튼;
    public Text 제목;
    public GameObject 왼쪽V표시;
    public GameObject 오른쪽V표시;
    public GameObject 언어창;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            덴지버튼.text = "Denji";
            제목.text = "Chainsaw Man";
            저장값 = 1;
        }
    }

    public void 한국어()
    {
        저장값 = 0;
        왼쪽V표시.SetActive(true);
        오른쪽V표시.SetActive(false);
    }
    public void 영어()
    {
        저장값 = 1;
        왼쪽V표시.SetActive(false);
        오른쪽V표시.SetActive(true);
    }
    public void OK()
    {
        if (저장값 == 0)
        {
            덴지버튼.text = "덴 지";
            아키버튼.text = "아 키";
            제목.text = "체인소 맨";
        }
        else
        {
            덴지버튼.text = "Denji";
            아키버튼.text = "Aki";
            제목.text = "Chainsaw Man";
        }
        PlayerPrefs.SetInt("EnKo", 저장값);
        언어창.SetActive(false);
    }
    public void 언어창켜기()
    {
        언어창.SetActive(true);
        if (저장값 == 0)
        {
            왼쪽V표시.SetActive(true);
            오른쪽V표시.SetActive(false);
        }
        else
        {
            왼쪽V표시.SetActive(false);
            오른쪽V표시.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
