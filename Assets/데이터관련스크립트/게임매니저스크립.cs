using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 게임매니저스크립 : MonoBehaviour {

    private enum State { 메인, 메인아님, /*채널쓰리*/}
    public enum 앱확인용종류 { 체인소맨, 봇치, 죠죠 }
    public 앱확인용종류 앱종류 = 앱확인용종류.체인소맨;
    [SerializeField]
    private State currentState = State.메인아님;
    public GameObject 즐겨찾기방광고팝업;
    public GameObject 즐겨찾기방광고실패팝업;

    public void 메인으로()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("메인");
    }
    public void 일번방()
    {
        배너광고.Instance().숨기자();
        switch (앱종류)
        {
            case 앱확인용종류.체인소맨:
                SceneManager.LoadScene("덴지");
                break;
            case 앱확인용종류.봇치:
                SceneManager.LoadScene("히토리");
                break;
            case 앱확인용종류.죠죠:
                SceneManager.LoadScene("죠셉");
                break;
        }
    }
    public void 이번방()
    {
        배너광고.Instance().숨기자();
            switch (앱종류)
            {
                case 앱확인용종류.체인소맨:
                    SceneManager.LoadScene("아키");
                    break;
                case 앱확인용종류.봇치:
                    SceneManager.LoadScene("니지카");
                    break;
                case 앱확인용종류.죠죠:
                    SceneManager.LoadScene("죠타로");
                    break;
            }
    }
    public void 삼번방()
    {
        배너광고.Instance().숨기자();
        switch (앱종류)
        {
            case 앱확인용종류.체인소맨:
                SceneManager.LoadScene("마키마");
                break;
            case 앱확인용종류.봇치:
                SceneManager.LoadScene("료");
                break;
            case 앱확인용종류.죠죠:
                SceneManager.LoadScene("죠스케");
                break;
        }
    }
    public void 사번방()
    {
        배너광고.Instance().숨기자();
        switch (앱종류)
        {
            case 앱확인용종류.체인소맨:
                SceneManager.LoadScene("파워");
                break;
            case 앱확인용종류.봇치:
                SceneManager.LoadScene("세이카");
                break;
            case 앱확인용종류.죠죠:
                SceneManager.LoadScene("디오");
                break;
        }
    }
   
    public void 오번방()
    {
        배너광고.Instance().숨기자();
        switch (앱종류)
        {
            case 앱확인용종류.체인소맨:
                SceneManager.LoadScene("히메노");
                break;
            case 앱확인용종류.봇치:
                SceneManager.LoadScene("세이카");
                break;
            case 앱확인용종류.죠죠:
                SceneManager.LoadScene("디오");
                break;
        }
    }
    public void 육번방()
    {
        배너광고.Instance().숨기자();
        switch (앱종류)
        {
            case 앱확인용종류.체인소맨:
                SceneManager.LoadScene("파워");
                break;
            case 앱확인용종류.봇치:
                SceneManager.LoadScene("세이카");
                break;
            case 앱확인용종류.죠죠:
                SceneManager.LoadScene("디오");
                break;
        }
    }
    public void 즐겨찾기방()
    {
        if (DataBase.Instance().모드종류 == DataBase.프리미엄모드.일반)
        {
            즐겨찾기방광고팝업.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("즐겨찾기방");
        }
        //SceneManager.LoadScene("즐겨찾기방");
    }
    public void 즐겨찾기광고보여줘()
    {
        슈퍼광고.Instance().즐겨찾기방입장광고보여줘(gameObject.GetComponent<게임매니저스크립>());
    }
    // Use this for initialization
    void Start () {
        if (currentState == State.메인아님)
        {
            슈퍼광고.Instance().로딩확인();
        }
	}
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(currentState == State.메인)
            {
                Application.Quit();
            }
            else
            {
                배너광고.Instance().숨기자();
                SceneManager.LoadScene("메인");
            }
        }
	}
}
