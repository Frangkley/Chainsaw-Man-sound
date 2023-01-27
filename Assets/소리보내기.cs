using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 소리보내기: MonoBehaviour
{
    public int 소리번호;
    public 소리재생스크립트 소리재생스크립트원본;
    public void 재생시키기()
    {
        소리재생스크립트원본.소리재생(소리번호);
    }
}
