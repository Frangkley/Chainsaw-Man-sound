using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 소리재생스크립트 : MonoBehaviour {

    public AudioSource 소리;
    public AudioClip[] 클립들;
    public TextAsset[] 클립공유용들;
    public void Awake()
    {
        슈퍼광고.Instance().소리재생스크립 = gameObject.GetComponent<소리재생스크립트>();
        DataBase.Instance().소리재생스크립 = gameObject.GetComponent<소리재생스크립트>();
        DataBase.Instance().소리개수 = 클립들.Length;
    }
    public void 소리재생(int 번호)
    {
        if ( 클립들.Length < 번호+1)
        {
            return;
        }
            소리.clip = 클립들[번호];
            소리.Play();
    }
    public void Count0()
    {
        소리.clip = 클립들[0];
        소리.Play();
    }
    public void Count1()
    {
        소리.clip = 클립들[1];
        소리.Play();
    }
    public void Count2()
    {
        소리.clip = 클립들[2];
        소리.Play();
    }
    public void Count3()
    {
        소리.clip = 클립들[3];
        소리.Play();
    }
    public void Count4()
    {
        소리.clip = 클립들[4];
        소리.Play();
    }
    public void Count5()
    {
        소리.clip = 클립들[5];
        소리.Play();
    }
    public void Count6()
    {
        소리.clip = 클립들[6];
        소리.Play();
    }
    public void Count7()
    {
        소리.clip = 클립들[7];
        소리.Play();
    }
    public void Count8()
    {
        소리.clip = 클립들[8];
        소리.Play();
    }
    public void Count9()
    {
        소리.clip = 클립들[9];
        소리.Play();
    }
    public void Count10()
    {
        소리.clip = 클립들[10];
        소리.Play();
    }
    public void Count11()
    {
        소리.clip = 클립들[11];
        소리.Play();
    }
    public void Count12()
    {
        소리.clip = 클립들[12];
        소리.Play();
    }
    public void Count13()
    {
        소리.clip = 클립들[13];
        소리.Play();
    }
    public void Count14()
    {
        소리.clip = 클립들[14];
        소리.Play();
    }
    public void Count15()
    {
        소리.clip = 클립들[15];
        소리.Play();
    }
    public void Count16()
    {
        소리.clip = 클립들[16];
        소리.Play();
    }
    public void Count17()
    {
        소리.clip = 클립들[17];
        소리.Play();
    }
    public void Count18()
    {
        소리.clip = 클립들[18];
        소리.Play();
    }
    public void Count19()
    {
        소리.clip = 클립들[19];
        소리.Play();
    }
    public void Count20()
    {
        소리.clip = 클립들[20];
        소리.Play();
    }
    public void Count21()
    {
        소리.clip = 클립들[21];
        소리.Play();
    }
    public void Count22()
    {
        소리.clip = 클립들[22];
        소리.Play();
    }
    public void Count23()
    {
        소리.clip = 클립들[23];
        소리.Play();
    }
    public void Count24()
    {
        소리.clip = 클립들[24];
        소리.Play();
    }
}
