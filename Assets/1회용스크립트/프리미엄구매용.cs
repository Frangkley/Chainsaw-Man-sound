using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �����̾����ſ�: MonoBehaviour
{
    public GameObject[] �����ÿ��͵�;
    public GameObject[] ���нÿ��͵�;
    // Start is called before the first frame update
    public GameObject[] �����͵�;

    public void ���δݾ��ּ���()
    {
        for (int i = 0; i < �����͵�.Length; i++)
        {
            �����͵�[i].SetActive(true);
        }
    }
    public void ���ο����ּ���()
    {
        for (int i = 0; i < �����ÿ��͵�.Length; i++)
        {
            �����ÿ��͵�[i].SetActive(true);
        }
    }
    public void ���ż�����()
    {
        DataBase.Instance().������� = DataBase.�����̾����.�����̾�;
        DataBase.Instance().�����̾������ϱ�();
        ��ʱ���.Instance().������();
        for (int i = 0; i < �����ÿ��͵�.Length; i++)
        {
            �����ÿ��͵�[i].SetActive(true);
        }
        for (int i = 0; i < �����͵�.Length; i++)
        {
            �����͵�[i].SetActive(false);
        }
    }
    public void ���н�()
    {
        for (int i = 0; i < ���нÿ��͵�.Length; i++)
        {
            ���нÿ��͵�[i].SetActive(true);
        }
        for (int i = 0; i < �����͵�.Length; i++)
        {
            �����͵�[i].SetActive(false);
        }
    }

}
