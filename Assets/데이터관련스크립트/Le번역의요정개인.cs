using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le번역의요정개인: MonoBehaviour
{
    public Color 색상값;
    public enum 방종류 { 개인 , 즐겨찾기 }
    public 방종류 방종류함수 = 방종류.개인;
    public GameObject 공유기능팝업;
    public GameObject 즐겨찾기개방창;
    public List<int> 수퍼동기화 = new List<int>();
    public List<int> 동기화 = new List<int>();
    public Text 케릭터이름;
    public string 세이브에넘겨줄케릭터이름;
    public string 케릭터이름영문;
    public Text[] 대사들;
    //public int 대사개수 = 0;
    public Text 광고설명;
    public Text 광고설명예;
    public Text 광고설명아니요;
    public Text 공유설명;
    public Text 공유설명예;
    public Text 공유설명아니요;
    public GameObject 광고실패창;
    public Text 광고실패창텍스트;
    public Text 광고실패창확인텍스트;
    public bool[] 즐겨찾기bool = new bool[20];
    public int 즐겨찾기끝 = 0;
    public int 비디오프리횟수 = 2;
    public int 케릭터최대횟수 = 5;
    public 소리재생스크립트 소리재생스크립번역쪽;
    public Sprite 히토리이미지;
    public Sprite 니지카이미지;
    public Sprite 료이미지;
    public Sprite 세이카이미지;
    public Sprite 덴지이미지;
    public Sprite 아키이미지;
    public Sprite 마키마이미지;
    public Sprite 파워이미지;
    public Sprite 히메노이미지;
    
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            케릭터이름.text = 케릭터이름영문;

            광고설명.text = "We're sorry, but this\n feature requires video\n viewing.\n\nvideo free : " + 비디오프리횟수 + " count\nCharacter Max : " + 케릭터최대횟수 + "\n\nPremium : Infinity";
            광고설명예.text = "Yes";
            광고설명아니요.text = "No";
            광고실패창텍스트.text = "Ad loading failed";
            광고실패창확인텍스트.text = "O K";
            
            공유설명.text = "We're sorry, but this\n feature requires video\n viewing.";
            공유설명예.text = "Yes";
            공유설명아니요.text = "No";
        }
        else
        {
            광고설명.text = "즐겨찾기 기능을 사용하기 위해\n광고를 시청하시겠습니까?" +
                "\n\n무료버전 : 광고시청시 "+ 비디오프리횟수+"회"+"\n케릭터당 최대 : "+케릭터최대횟수+"개\n\n프리미엄 : 무제한";
        }

        DataBase 임시데타베이스 = DataBase.Instance();
        임시데타베이스.세이브이름 = 세이브에넘겨줄케릭터이름;
       슈퍼광고.Instance().영문이름 = 케릭터이름영문;

        임시데타베이스.즐찾용불러오기();
        if (방종류함수 == 방종류.개인)
        {
            임시데타베이스.불러오기();

            동기화 = 임시데타베이스.언어원.즐겨찾기자기번호리스트;

            for (int i = 0; i < 동기화.Count; i++)
            {
                int ang = 동기화[i];
                GameObject 부모 = 대사들[ang].transform.parent.gameObject;
                부모.gameObject.transform.SetSiblingIndex(i);
                부모.transform.GetChild(1).gameObject.GetComponent<창열거나닫자>().별표표시();
            }
            if (PlayerPrefs.GetInt("EnKo") != 0)
            {
                for (int i = 0; i < 소리재생스크립번역쪽.클립들.Length; i++)
                {
                    대사들[i].text = 대사들[i].GetComponent<KoenS>().En;
                }
            }
            else
            {
                for (int i = 0; i < 소리재생스크립번역쪽.클립들.Length; i++)
                {
                    대사들[i].text = 대사들[i].GetComponent<KoenS>().Ko;
                }
            }
        }
        else
        {
            int ii = 임시데타베이스.언어투.삭제정보용.Count;
            if (ii < 1)
            {
                for (int i = ii; i < 35; i++)
                {
                    대사들[i].gameObject.transform.parent.gameObject.SetActive(false);
                }
                return;
            }
            if (ii > 0)
            {
                if (ii >35)
                {
                    ii = 35;
                }
                if (PlayerPrefs.GetInt("EnKo") != 0)
                {
                    케릭터이름.text = 케릭터이름.text + "     "+ii+" / "+"35";
                }
                else
                {
                    케릭터이름.text = 세이브에넘겨줄케릭터이름 + "     " + ii + " / " + "35";
                }
                소리재생스크립번역쪽.클립들 = new AudioClip[ii];
                소리재생스크립번역쪽.클립공유용들 = new TextAsset[ii];
                if (ii < 35)
                {
                    for (int i = ii; i < 35; i++)
                    {
                       대사들[i].gameObject.transform.parent.gameObject.SetActive(false);
                    }
                }
                for (int i = 0; i < ii; i++)
                {
                    if (PlayerPrefs.GetInt("EnKo") != 0)
                    {
                        대사들[i].text = 임시데타베이스.즐찾영문동기화용[i];
                    }
                    else
                    {
                        대사들[i].text = 임시데타베이스.즐찾한국어동기화용[i];
                    }
                    대사들[i].fontSize = 임시데타베이스.즐찾글자크기동기화용[i];
                  RectTransform 일회용렉트 = 대사들[i].transform.parent.gameObject.GetComponent<RectTransform>();
                    일회용렉트.sizeDelta = new Vector2(일회용렉트.sizeDelta.x, 임시데타베이스.즐찾높이동기화용[i]);
                    소리재생스크립번역쪽.클립들[i] = 임시데타베이스.즐찾오디오리스트동기화용[i];
                    소리재생스크립번역쪽.클립공유용들[i] = 임시데타베이스.즐찾오디오저장용리스트동기화용[i];
                    string 일회용이름 = 임시데타베이스.즐찾이름동기화용[i];
                    GameObject 일회용부모 = 대사들[i].gameObject.transform.parent.gameObject;
                 
                    switch (일회용이름)
                    {
                        case "히토리" :
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 히토리이미지;
                            break;
                        case "니지카":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 니지카이미지;
                            break;
                        case "료":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 료이미지;
                            break;
                        case "세이카":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 세이카이미지;
                            break;
                        case "덴지":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 덴지이미지;
                            break;
                        case "아키":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 아키이미지;
                            break;
                        case "파워":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 파워이미지;
                            break;
                        case "마키마":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 마키마이미지;
                            break;
                        case "히메노":
                            일회용부모.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = 히메노이미지;
                            break;
                        default:
                            break;
                    }
                    //대사들[i].transform.parent.gameObject.GetComponent<RectTransform>().sizeDelta.y = DataBase.Instance().즐찾높이동기화용[i];
                    /*int ang = 동기화[i];
                    GameObject 부모 = 대사들[ang].transform.parent.gameObject;
                    부모.gameObject.transform.SetSiblingIndex(i);
                    부모.transform.GetChild(1).gameObject.GetComponent<창열거나닫자>().별표표시();*/
                }
            }

        }
    }
    public void 우낑(int 받은번호)
    {
        즐겨찾기끝 = 동기화.Count;
        동기화.Add(받은번호);
        DataBase.Instance().언어원.즐겨찾기자기번호리스트 = 동기화;
        DataBase.Instance().저장하기();
        #region 혹시몰라
        /*
            DataBase.Instance().세이브이름 = 세이브에넘겨줄케릭터이름;
        if (DataBase.instance.언어.즐겨찾기자기번호리스트.Count == 0)
        {
            DataBase.instance.언어.즐겨찾기자기번호리스트.Add(받은번호);
        }
        else
        {/*
            for (int i = 0; i < DataBase.instance.언어.즐겨찾기자기번호리스트.Count; i++)
            {
                DataBase.instance.언어.즐겨찾기자기번호리스트.Add(받은번호);
                즐겨찾기bool[i] = true;

                print(DataBase.instance.언어.즐겨찾기자기번호리스트);
            }
            
        }
        print(DataBase.instance.언어.즐겨찾기자기번호리스트[0]);
        즐겨찾기끝 = DataBase.instance.언어.즐겨찾기자기번호리스트.Count;

        /*for (int i = 0; i < 21; i++)
        {
           

            if (File.Exists(DataBase.instance.즐겨찾기저장공간 + $"{i}"))
            {
                즐겨찾기bool[i] = true;
               // DataBase.instance.newSlot = i;
              //  DataBase.instance.저장하기();
            }
            else
            {
                즐겨찾기끝 = i;
                //DataBase.instance.newSlot = i;
                DataBase.instance.저장하기();
                break;
            }


        }
        print(즐겨찾기끝 + "끝");*/
        #endregion
    }
    // Start is called before the first frame update
    public void 우낑빼기(int 받은번호)
    {
        if (동기화.Count == 1)
        {
            동기화.Clear();
        }
        else
        {
            int nIndex = 동기화.IndexOf(받은번호);
            동기화.RemoveAt(nIndex);
         
        }
        DataBase.Instance().언어원.즐겨찾기자기번호리스트 = 동기화;
        DataBase.Instance().저장하기();

    }
    public void 초기화용()
    {
        DataBase.Instance().언어원.즐겨찾기자기번호리스트 = 수퍼동기화;
        DataBase.Instance().저장하기();
    }

}
