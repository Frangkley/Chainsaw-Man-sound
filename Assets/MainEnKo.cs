using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public int ���尪 = 0;
    public Text ������ư;
    public Text ��Ű����ư;
    public GameObject ����Vǥ��;
    public GameObject ������Vǥ��;
    public GameObject ���â;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            ������ư.text = "Denji";
            ���尪 = 1;
        }
    }

    public void �ѱ���()
    {
        ���尪 = 0;
        ����Vǥ��.SetActive(true);
        ������Vǥ��.SetActive(false);
    }
    public void ����()
    {
        ���尪 = 1;
        ����Vǥ��.SetActive(false);
        ������Vǥ��.SetActive(true);
    }
    public void OK()
    {
        if (���尪 == 0)
        {
            ������ư.text = "�� ��";
        }
        else
        {
            ������ư.text = "Denji";
        }
        PlayerPrefs.SetInt("EnKo", ���尪);
        ���â.SetActive(false);
    }
    public void ���â�ѱ�()
    {
        ���â.SetActive(true);
        if (���尪 == 0)
        {
            ����Vǥ��.SetActive(true);
            ������Vǥ��.SetActive(false);
        }
        else
        {
            ����Vǥ��.SetActive(false);
            ������Vǥ��.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
