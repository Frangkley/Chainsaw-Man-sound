using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ���δݱ� : MonoBehaviour
{

    public GameObject[] �����͵�;

    public void ���δݾ��ּ���()
    {
        for (int i = 0; i < �����͵�.Length; i++)
        {
            �����͵�[i].SetActive(false);
        }
    }
}
