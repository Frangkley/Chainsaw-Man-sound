using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 창열거나닫자 : MonoBehaviour {

    public GameObject 닫을거;
    public GameObject 열거;

    public void ZOpen()
    {
        열거.SetActive(true);
    }
    public void ZClose()
    {
        닫을거.SetActive(false);
    }
}
