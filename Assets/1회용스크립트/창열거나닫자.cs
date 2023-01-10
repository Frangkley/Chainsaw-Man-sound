using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//        [ExecuteInEditMode]
public class 창열거나닫자 : MonoBehaviour {

    public GameObject 닫을거;
    public GameObject 열거;
    public bool 온오프 = false;
    public Le번역의요정개인 번역스크립트;
    public GameObject 부모;
    public int 자기번호;
    public void Start()
    {
        // 부모 = gameObject.transform.parent.gameObject;
      //  자기번호 = 부모.GetComponent<자기번호>().번호;
    }
    public void 별표표시()
    {
        온오프 = true;
        열거.SetActive(true);
    }
    public void 즐찾표시()
    {
        if (!온오프 && 번역스크립트.동기화.Count <= 20)
        {
            온오프 = true;
            열거.SetActive(true);
            //DataBase.Instance().불러오기();
            번역스크립트.우낑(자기번호);
            부모.gameObject.transform.SetSiblingIndex(번역스크립트.즐겨찾기끝);
            //  DataBase.instance.newSlot = number;
        }
        else if (온오프)
        {
            온오프 = false;
            열거.SetActive(false);
            int Gb = transform.GetSiblingIndex();
            번역스크립트.우낑빼기(Gb);
            부모.gameObject.transform.SetSiblingIndex(자기번호 + 번역스크립트.동기화.Count);
        }



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
