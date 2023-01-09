using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 생성용: MonoBehaviour
{
    public GameObject[] 버튼들;
    public GameObject 별네모;
    public int 배열수;
    public Vector3 originScale;
    public int 빠빠기 = 1;
    void Start()
    {
        빠빠기 = 3;
        배열수 = 버튼들.Length;
        for(int i= 0; i<배열수;)
        {
            GameObject 생성 = Instantiate(별네모, transform.localPosition, transform.localRotation) as GameObject;
            originScale = 생성.transform.localScale;
            생성.transform.SetParent(버튼들[i].gameObject.transform);
            생성.transform.localScale = originScale;
            i++;
        }
    }

}
