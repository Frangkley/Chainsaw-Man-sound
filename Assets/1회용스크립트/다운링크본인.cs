using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �ٿũ���� : MonoBehaviour
{
    public string �ѱ۸�ũ = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public string ���ũ = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
    public GameObject ���δݱ�;
    // Start is called before the first frame update
    public void �˾��ѱ�()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            Application.OpenURL(���ũ);
        }
        else
        {
            Application.OpenURL(�ѱ۸�ũ);
        }
    }
}
