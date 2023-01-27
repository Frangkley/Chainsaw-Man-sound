using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public enum State { 체인소맨, 봇치, 죠죠 }
    public State 앱이름 = State.체인소맨;
    public int 저장값 = 1;
    public Text 덴지버튼;
    public Text 마키마버튼;
    public Text 아키버튼;
    public Text 파워버튼;
    public Text 제목;
    public Text 즐겨찾기;
    public GameObject 왼쪽V표시;
    public GameObject 오른쪽V표시;
    public GameObject 언어창;
    public GameObject 다른앱보기제거;
    public Text 공지사항제목;
    public Text 공지사항내용;
    [TextArea]
    public string 공지사항내용붙여넣기한국어;
    [TextArea]
    public string 공지사항내용붙여넣기영어;
    public Text 광고팝업텍스트;
    public Text 광고팝업텍스트예;
    public Text 광고팝업텍스트아니요;
    public Text 광고팝업텍스트프리미엄;
    public Text 프리미엄제목;
    public Text 프리미엄내용;
    public Text 프리미엄취소버튼;
    public Text 프리미엄구매버튼;
    public Text 결제실패내용;
    public Text 결제실패내용확인;
    public Text 결제성공내용;
    public Text 결제성공내용확인;
    public GameObject 프리미엄구매아이콘;
    public GameObject 공지사항팝업창;
    public string subject = "체인소맨 음성대사모음";
    public string body = "https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US";
    public void Awake()
    {
        if (앱이름 != State.죠죠)
        {
            if (!PlayerPrefs.HasKey("EnKo"))
            {
                PlayerPrefs.SetInt("EnKo", 1);
                언어창켜기();
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        if (앱이름 != State.죠죠)
        {
            저장값 = PlayerPrefs.GetInt("EnKo");
            if (저장값 == 0)
            {
                한글로();
            }
            else
            {
                영어로();
            }
        }
        if (DataBase.Instance().모드종류 == DataBase.프리미엄모드.일반)
        {
            프리미엄구매아이콘.SetActive(true);
        }
        if (DataBase.Instance().공지사항팝업띄울지여부 == true)
        {
            공지사항팝업창.SetActive(true);
            DataBase.Instance().공지사항팝업띄울지여부 = false;
        }
    }
    public void 영어로()
    {
        영어공통();
        switch (앱이름)
        {
            case State.체인소맨:
                덴지버튼.text = "Denji";
                아키버튼.text = "Aki";
                마키마버튼.text = "Makima";
                파워버튼.text = "Power";
                제목.text = "Chainsaw\nMan";
                제목.fontSize = 15;
                공지사항제목.text = "Notice";
                공지사항내용.text = "These are the lines\nfrom the contents up\nto episode 3.\n\nWe will update\nwhen the number of\ndownloads increases!";
                즐겨찾기.text = "Favorites";
                subject = "Chainsaw Man Characters sound";
             

                break;
            case State.봇치:
                덴지버튼.text = "Hitori";
                아키버튼.text = "Nijika";
                마키마버튼.text = "Ryo";
                파워버튼.text = "Seika";
                제목.text = "Bocchi the\nRock!";
                제목.fontSize = 15;
                공지사항제목.text = "Notice";
                공지사항내용.text = "These are the lines\nfrom the contents up\nto episode 2.\n\nWe will update\nwhen the number of\ndownloads increases!";
                즐겨찾기.text = "Favorites";
                subject = "Bocchi the Rock! Characters sound";
                break;
            default:
                break;
        }
    }
    public void 한글공통()
    {

        즐겨찾기.text = "즐겨찾기";
        //다른앱보기제거.SetActive(true);
        광고팝업텍스트.text = "즐겨찾기는 프리미엄 전용입니다\n\n무료 버전은 입장할 때마다\n동영상 시청이 필요합니다";
        광고팝업텍스트예.text = "동영상 시청(무료)";
        광고팝업텍스트예.fontSize = 15;
        광고팝업텍스트아니요.text = "취소";
        광고팝업텍스트프리미엄.text = "프리미엄 이용권";
        프리미엄구매버튼.text = "프리미엄 이용권";
        프리미엄내용.text = "-광고 없음(다운,공유 무제한)\n-케릭터 즐겨찾기\n  제한없음\n-즐겨찾기방\n  최대 : 35";
        프리미엄제목.text = "프리미엄 혜택";
        프리미엄취소버튼.text = "취 소";
        결제실패내용.text = "결제 취소";
        결제실패내용확인.text = "확인";
        결제성공내용.text = "결제 성공";
        결제성공내용확인.text = "확인";

    }
    public void 영어공통()
    {
        저장값 = 1;
        //다른앱보기제거.SetActive(false);
        광고팝업텍스트.text = "We're sorry, but this\n feature requires video\n viewing.";
        광고팝업텍스트예.text = "GET FOR FREE (AD)";
        광고팝업텍스트예.fontSize = 13;
        광고팝업텍스트아니요.text = "CANCLE";
        광고팝업텍스트프리미엄.text = "GET PREMIUM";
        프리미엄구매버튼.text = "GET PREMIUM";
        프리미엄내용.text = "-No AD\n-No bookmark\n  restrictions\n-FavoritesRoom \n  Max : 35";
        프리미엄제목.text = "PREMIUM Ver";
        프리미엄취소버튼.text = "CANCLE";
        결제실패내용.text = "CANCLE";
        결제실패내용확인.text = "O K";
        결제성공내용.text = "The bill has\n been paid";
        결제성공내용확인.text = "O K";

    }
    public void 한글로()
    {
        한글공통();
        switch (앱이름)
        {
            case State.체인소맨:
                덴지버튼.text = "덴 지";
                아키버튼.text = "아 키";
                마키마버튼.text = "마키마";
                파워버튼.text = "파워";
                제목.text = "체인소 맨";
                제목.fontSize = 22;
                공지사항제목.text = "공 지 사 항";
                공지사항내용.text = 공지사항내용붙여넣기한국어;
                subject = "체인소맨 음성대사모음";
                break;
            case State.봇치:
                덴지버튼.text = "히토리";
                아키버튼.text = "니지카";
                마키마버튼.text = "료";
                파워버튼.text = "세이카";
                제목.text = "봇치 더 록!";
                제목.fontSize = 22;
                공지사항제목.text = "공 지 사 항";
                공지사항내용.text = "현재 2화까지의 내용에서 \n 나온 대사들 입니다. \n\n다운로드수가 늘어나면\n업데이트하겠습니다!";
                subject = "봇치 더 록!";
                break;
            default:
                break;
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
        
      
        //체인소맨
        /**/
        //봇치
       
        switch (앱이름)
        {
            case State.체인소맨:
                if (저장값 == 0)
                {
                    body = "https://play.google.com/store/apps/details?id=com.bef.chainsawmansound";
                }
                else
                {
                    body = "https://play.google.com/store/apps/details?id=com.bef.chainsawmansound&hl=ko&gl=US";
                }
                break;
            case State.봇치:
                if (저장값 == 0)
                {
                    body = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
                }
                else
                {
                    body = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
                }
                break;
            case State.죠죠:
                body = "https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US";
                break;
            default:
                break;
        }
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
        //찐죠죠
        //Application.OpenURL("https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US");

        //체인소맨
        if (저장값 == 0)
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.bef.chainsawmansound");
        }
        else
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.bef.chainsawmansound&hl=ko&gl=US");
        }
        //봇치
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
            한글로();
        }
        else
        {
            영어로();
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
