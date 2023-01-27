using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abb : MonoBehaviour
{
    public int 응깃 = 1;
    public List<int> 동기화 = new List<int>();
    public void Start()
    {
        DataBase.Instance().세이브이름 = "덴지";
        DataBase.Instance().불러오기();
       동기화 = DataBase.Instance().언어원.즐겨찾기자기번호리스트;
    }

    public void 늘어나라()
    {
        동기화.Add(응깃);
        응깃+= 2;
        DataBase.Instance().언어원.즐겨찾기자기번호리스트 = 동기화;
        DataBase.Instance().저장하기();
        print(DataBase.Instance().언어원.즐겨찾기자기번호리스트.Count);
        /*DataBase.instance.언어원.즐겨찾기자기번호리스트.Add(응깃);
        응깃++;
        print(DataBase.instance.언어원.즐겨찾기자기번호리스트);*/
    }
    public void 줄어들어라()
    {

    }
}
