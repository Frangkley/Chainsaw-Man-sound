using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le�����ǿ�������: MonoBehaviour
{
    public GameObject ���ã�ⰳ��â;
    public List<int> ���۵���ȭ = new List<int>();
    public List<int> ����ȭ = new List<int>();
    public Text �ɸ����̸�;
    public string ���̺꿡�Ѱ����ɸ����̸�;
    public string �ɸ����̸�����;
    public Text[] ����;
    public Text ������;
    public Text ������;
    public Text ������ƴϿ�;
    public GameObject �������â;
    public Text �������â�ؽ�Ʈ;
    public Text �������âȮ���ؽ�Ʈ;
    public bool[] ���ã��bool = new bool[20];
    public int ���ã�ⳡ = 0;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �ɸ����̸�.text = �ɸ����̸�����;
            ������.text = "To use the Favorites \n feature You have to \n watch the commercial.";
            ������.text = "Yes";
            ������ƴϿ�.text = "No";
            �������â�ؽ�Ʈ.text = "OK";
            �������âȮ���ؽ�Ʈ.text = "Ad loading failed";
            
        }
        DataBase.Instance().���̺��̸� = ���̺꿡�Ѱ����ɸ����̸�;
        DataBase.Instance().�ҷ�����();
        ����ȭ = DataBase.Instance().���.���ã���ڱ��ȣ����Ʈ;

        for (int i = 0; i < ����ȭ.Count; i++)
        {
            int ang = ����ȭ[i];
           GameObject �θ� = ����[ang].transform.parent.gameObject;
            �θ�.gameObject.transform.SetSiblingIndex(i);
            �θ�.transform.GetChild(1).gameObject.GetComponent<â���ų�����>().��ǥǥ��();
        }
    }
    public void �쳩(int ������ȣ)
    {
        ���ã�ⳡ = ����ȭ.Count;
        ����ȭ.Add(������ȣ);
        DataBase.Instance().���.���ã���ڱ��ȣ����Ʈ = ����ȭ;
        DataBase.Instance().�����ϱ�();
        #region Ȥ�ø���
        /*
            DataBase.Instance().���̺��̸� = ���̺꿡�Ѱ����ɸ����̸�;
        if (DataBase.instance.���.���ã���ڱ��ȣ����Ʈ.Count == 0)
        {
            DataBase.instance.���.���ã���ڱ��ȣ����Ʈ.Add(������ȣ);
        }
        else
        {/*
            for (int i = 0; i < DataBase.instance.���.���ã���ڱ��ȣ����Ʈ.Count; i++)
            {
                DataBase.instance.���.���ã���ڱ��ȣ����Ʈ.Add(������ȣ);
                ���ã��bool[i] = true;

                print(DataBase.instance.���.���ã���ڱ��ȣ����Ʈ);
            }
            
        }
        print(DataBase.instance.���.���ã���ڱ��ȣ����Ʈ[0]);
        ���ã�ⳡ = DataBase.instance.���.���ã���ڱ��ȣ����Ʈ.Count;

        /*for (int i = 0; i < 21; i++)
        {
           

            if (File.Exists(DataBase.instance.���ã��������� + $"{i}"))
            {
                ���ã��bool[i] = true;
               // DataBase.instance.newSlot = i;
              //  DataBase.instance.�����ϱ�();
            }
            else
            {
                ���ã�ⳡ = i;
                //DataBase.instance.newSlot = i;
                DataBase.instance.�����ϱ�();
                break;
            }


        }
        print(���ã�ⳡ + "��");*/
        #endregion
    }
    // Start is called before the first frame update
    public void �쳩����(int ������ȣ)
    {
        if (����ȭ.Count == 1)
        {
            ����ȭ.Clear();
        }
        else
        {
            ����ȭ.RemoveAt(������ȣ);
         
        }
        DataBase.Instance().���.���ã���ڱ��ȣ����Ʈ = ����ȭ;
        DataBase.Instance().�����ϱ�();

    }
    public void �ʱ�ȭ��()
    {
        DataBase.Instance().���.���ã���ڱ��ȣ����Ʈ = ���۵���ȭ;
        DataBase.Instance().�����ϱ�();
    }

}
