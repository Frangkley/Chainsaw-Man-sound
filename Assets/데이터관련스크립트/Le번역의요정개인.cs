using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le번역의요정개인: MonoBehaviour
{
    public GameObject 즐겨찾기개방창;
    public List<int> 수퍼동기화 = new List<int>();
    public List<int> 동기화 = new List<int>();
    public Text 케릭터이름;
    public string 세이브에넘겨줄케릭터이름;
    public string 케릭터이름영문;
    public Text[] 대사들;
    public Text 광고설명;
    public Text 광고설명예;
    public Text 광고설명아니요;
    public GameObject 광고실패창;
    public Text 광고실패창텍스트;
    public Text 광고실패창확인텍스트;
    public bool[] 즐겨찾기bool = new bool[20];
    public int 즐겨찾기끝 = 0;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            케릭터이름.text = 케릭터이름영문;
            광고설명.text = "To use the Favorites \n feature You have to \n watch the commercial.";
            광고설명예.text = "Yes";
            광고설명아니요.text = "No";
            광고실패창텍스트.text = "OK";
            광고실패창확인텍스트.text = "Ad loading failed";
            
        }
        DataBase.Instance().세이브이름 = 세이브에넘겨줄케릭터이름;
        DataBase.Instance().불러오기();
        동기화 = DataBase.Instance().언어.즐겨찾기자기번호리스트;

        for (int i = 0; i < 동기화.Count; i++)
        {
            int ang = 동기화[i];
           GameObject 부모 = 대사들[ang].transform.parent.gameObject;
            부모.gameObject.transform.SetSiblingIndex(i);
            부모.transform.GetChild(1).gameObject.GetComponent<창열거나닫자>().별표표시();
        }
    }
    public void 우낑(int 받은번호)
    {
        즐겨찾기끝 = 동기화.Count;
        동기화.Add(받은번호);
        DataBase.Instance().언어.즐겨찾기자기번호리스트 = 동기화;
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
            동기화.RemoveAt(받은번호);
         
        }
        DataBase.Instance().언어.즐겨찾기자기번호리스트 = 동기화;
        DataBase.Instance().저장하기();

    }
    public void 초기화용()
    {
        DataBase.Instance().언어.즐겨찾기자기번호리스트 = 수퍼동기화;
        DataBase.Instance().저장하기();
    }

}
