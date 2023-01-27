using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
     //   [ExecuteInEditMode]
public class 창열거나닫자 : MonoBehaviour {
    public 창열거나닫자 공유기능팝업스크립트;
    public GameObject 닫을거;
    public GameObject 열거;
    public bool 온오프 = false;
    public Le번역의요정개인 번역스크립트;
    public GameObject 부모;
    public int 자기번호;
    public DataBase 데타베이스크립트;
    public int 케릭터당제한 = 5;
    public void Awake()
    {
        데타베이스크립트 = DataBase.Instance();
    }
    /*
    public void Start()
    {
        // 부모 = gameObject.transform.parent.gameObject;
       // 자기번호 = 부모.GetComponent<자기번호>().번호;
    }*/
    public void 닫고열기()
    {
        열거.SetActive(true);
        닫을거.SetActive(false);
    }
    public void 별표표시()
    {
        온오프 = true;
        열거.SetActive(true);
    }
    public void 광고보여줘()
    {
        슈퍼광고.Instance().즐겨찾기광고보여줘(번역스크립트.세이브에넘겨줄케릭터이름, 번역스크립트);
        닫을거.SetActive(false);
    }
    public void 공유기능광고보여줘()
    {
        if (DataBase.Instance().모드종류 == DataBase.프리미엄모드.일반)
        {
            열거.SetActive(true);
            공유기능팝업스크립트.자기번호 = 자기번호;
        }
        else
        {
            공유기능팝업스크립트.자기번호 = 자기번호;
            슈퍼광고.Instance().무료로공유해드립니다(자기번호, 번역스크립트);
        }
    }
    public void 공유기능광고진짜보여주기()
    {
        슈퍼광고.Instance().음성공유광고보여줘(자기번호, 번역스크립트);
        닫을거.SetActive(false);
    }
    public void 즐찾표시()
    {
        //캐릭터단위일때
        /*
        if(PlayerPrefs.GetInt(번역스크립트.세이브에넘겨줄케릭터이름) !=1)
        {
            Debug.Log(PlayerPrefs.GetInt(번역스크립트.세이브에넘겨줄케릭터이름));
            번역스크립트.즐겨찾기개방창.SetActive(true);
            return;
        }*/
        DataBase 임시참고용 = DataBase.Instance();

        int bar = DataBase.Instance().소리개수 - 2;
        if (임시참고용.모드종류 == DataBase.프리미엄모드.일반)
        {
            int 즐찾횟수 = PlayerPrefs.GetInt("즐찾횟수");
            if (!온오프)
            {
                if (번역스크립트.동기화.Count >= 케릭터당제한)
                {
                    return;
                }
                else if (즐찾횟수 <= 0)
                {
                    번역스크립트.즐겨찾기개방창.SetActive(true);
                    return;
                }
            }

            if (!온오프 && 번역스크립트.동기화.Count <= 5 /*&& 번역스크립트.동기화.Count < bar*/)
            {
                PlayerPrefs.SetInt("즐찾횟수", 즐찾횟수 - 1);
                즐찾간소화함수();
                /* DataBase.Instance().오디오추가(자기번호, 임시번역스크립트.글씨크기, 
                     임시번역스크립트.Ko, 임시번역스크립트.En, 
                     gameObject.transform.parent.gameObject.GetComponent<RectTransform>().rect.height);*/
                //  DataBase.instance.newSlot = number;
            }
            else if (온오프)
            {
                즐찾간소화함수오프();
            }
        }
       
        else
        {
           if  (!온오프/* && 번역스크립트.동기화.Count < bar*/)
            {
                즐찾간소화함수();
            }
           else if (온오프)
            {
                즐찾간소화함수오프();
            }
        }
    }
    public void 즐찾간소화함수()
    {
        온오프 = true;
        열거.SetActive(true);
        //DataBase.Instance().불러오기();
        번역스크립트.우낑(자기번호);
        if (번역스크립트.동기화.Count != DataBase.Instance().소리재생스크립.클립들.Length)
        {
            부모.gameObject.transform.SetSiblingIndex(번역스크립트.즐겨찾기끝);
        }
        KoenS 임시번역스크립트 = 부모.transform.GetChild(0).gameObject.GetComponent<KoenS>();
        데타베이스크립트.즐찾글자크기동기화용.Add(임시번역스크립트.글씨크기);
        데타베이스크립트.즐찾높이동기화용.Add(gameObject.transform.parent.gameObject.GetComponent<RectTransform>().sizeDelta.y);
        데타베이스크립트.즐찾영문동기화용.Add(임시번역스크립트.En);
        데타베이스크립트.즐찾한국어동기화용.Add(임시번역스크립트.Ko);
        데타베이스크립트.즐찾오디오리스트동기화용.Add(데타베이스크립트.소리재생스크립.클립들[자기번호]);
        데타베이스크립트.즐찾오디오저장용리스트동기화용.Add(데타베이스크립트.소리재생스크립.클립공유용들[자기번호]);
        데타베이스크립트.즐찾이름동기화용.Add(데타베이스크립트.세이브이름);
        데타베이스크립트.즐찾번호동기화용.Add(자기번호);
        데타베이스크립트.즐찾삭제정보용.Add(데타베이스크립트.세이브이름 + 자기번호);
        데타베이스크립트.즐찾용저장();
    }
    public void 즐찾간소화함수오프()
    {
        온오프 = false;
        열거.SetActive(false);
        //int Gb = transform.GetSiblingIndex();
        번역스크립트.우낑빼기(자기번호);
        데타베이스크립트.즐찾용제거(자기번호);
         부모.gameObject.transform.SetSiblingIndex(번역스크립트.동기화.Count);
       // Debug.Log(자기번호 + 번역스크립트.동기화.Count);
        /*
        if (번역스크립트.동기화.Count != DataBase.Instance().소리재생스크립.클립들.Length)
        {
            부모.gameObject.transform.SetSiblingIndex(자기번호 + 번역스크립트.동기화.Count);
        }
        */
    }
    public void ZOpen()
    {
        열거.SetActive(true);
    }
    public void ZClose()
    {
        닫을거.SetActive(false);
    }
}
