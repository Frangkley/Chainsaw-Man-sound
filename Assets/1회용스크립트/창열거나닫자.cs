using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class 창열거나닫자 : MonoBehaviour {

    public GameObject 닫을거;
    public GameObject 열거;
    public bool 온오프 = false;
    public Le번역의요정개인 번역스크립트;
    public GameObject 부모;
    public int 자기번호;
    public void 즐찾표시()
    {
        if (!온오프)
        {
            온오프 = true;
            열거.SetActive(true);
            부모.gameObject.transform.SetSiblingIndex(0);
          //  DataBase.instance.newSlot = number;
        }
        else
        {
            온오프 = false;
            열거.SetActive(false);
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
