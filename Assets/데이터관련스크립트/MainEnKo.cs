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
    public Text 파워버튼;
    public Text 제목;
    public GameObject 왼쪽V표시;
    public GameObject 오른쪽V표시;
    public GameObject 언어창;
    public GameObject 다른앱보기제거;
    public Text 공지사항제목;
    public Text 공지사항내용;
    public string subject = "체인소맨 음성대사모음";
    public string body = "https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US";
    public void Awake()
    {
        if (!PlayerPrefs.HasKey("Enko"))
        {
            PlayerPrefs.SetInt("Enko", 0);
            언어창켜기();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            덴지버튼.text = "Denji";
            아키버튼.text = "Aki";
            마키마버튼.text = "Makima";
            파워버튼.text = "Power";
            제목.text = "Chainsaw\nMan";
            제목.fontSize = 15;
            공지사항제목.text = "Notice";
            공지사항내용.text = "These are the lines\nfrom the contents up\nto episode 3.\n\nWe will update\nwhen the number of\ndownloads increases!";
            저장값 = 1;
            다른앱보기제거.SetActive(false);
            subject = "Chainsaw Man Characters sound";
        }
        else
        {
            공지사항내용.text = "현재 3화까지의 내용에서 \n 나온 대사들 입니다.\n(아키 콩 제외)\n\n다운로드수가 늘어나면\n업데이트하겠습니다!\n\n----------\n1.2ver\n공유기능업데이트!";
        }

    }
    public void ShareApp()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            // SoundManager.instance.PlayExf(0);
            StartCoroutine(ShareAndroidText());
        }
    }

    IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device
#if UNITY_ANDROID
        body = "https://play.google.com/store/apps/details?id=com.bef.chainsawmansound";
        //Reference of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //Reference of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created


        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TITLE"), "Text Sharing ");
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Via");
        currentActivity.Call("startActivity", jChooser);
#endif
    }
    public void 죠죠링크()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US");
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
            마키마버튼.text = "마키마";
            파워버튼.text = "파워";
            제목.text = "체인소 맨";
            제목.fontSize = 22;
            공지사항제목.text = "공 지 사 항";
            공지사항내용.text = "현재 3화까지의 내용에서 \n 나온 대사들 입니다.\n(아키 콩 제외)\n\n다운로드수가 늘어나면\n업데이트하겠습니다!\n\n----------\n1.2ver\n공유기능업데이트!";
            subject = "체인소맨 음성대사모음";
            다른앱보기제거.SetActive(true);
        }
        else
        {
            덴지버튼.text = "Denji";
            아키버튼.text = "Aki";
            마키마버튼.text = "Makima";
            파워버튼.text = "Power";
            제목.text = "Chainsaw\nMan";
            제목.fontSize = 15;
            공지사항제목.text = "Notice";
            공지사항내용.text = "These are the lines\nfrom the contents up\nto episode 3.\n\nWe will update\nwhen the number of\ndownloads increases!";
            subject = "Chainsaw Man Characters sound";
            다른앱보기제거.SetActive(false);
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
}
