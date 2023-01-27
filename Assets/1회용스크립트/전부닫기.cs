using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 전부닫기 : MonoBehaviour
{

    public GameObject[] 닫을것들;

    public void 전부닫아주세요()
    {
        for (int i = 0; i < 닫을것들.Length; i++)
        {
            닫을것들[i].SetActive(false);
        }
    }
}
