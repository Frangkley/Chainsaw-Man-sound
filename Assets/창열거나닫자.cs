using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class 창열거나닫자 : MonoBehaviour {

    public GameObject 닫을거;
    public GameObject 열거;
    public bool 온오프 = false;
    public void Awake()
    {
        열거 = gameObject.transform.GetChild(0).gameObject;
    }
    public void 즐찾표시()
    {
        if (!온오프)
        {
            온오프 = true;
            열거.SetActive(true);
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
