using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le�����ǿ�������: MonoBehaviour
{
    public Color ����;
    public enum ������ { ���� , ���ã�� }
    public ������ �������Լ� = ������.����;
    public GameObject ��������˾�;
    public GameObject ���ã�ⰳ��â;
    public List<int> ���۵���ȭ = new List<int>();
    public List<int> ����ȭ = new List<int>();
    public Text �ɸ����̸�;
    public string ���̺꿡�Ѱ����ɸ����̸�;
    public string �ɸ����̸�����;
    public Text[] ����;
    //public int ��簳�� = 0;
    public Text ������;
    public Text ������;
    public Text ������ƴϿ�;
    public Text ��������;
    public Text ��������;
    public Text ��������ƴϿ�;
    public GameObject �������â;
    public Text �������â�ؽ�Ʈ;
    public Text �������âȮ���ؽ�Ʈ;
    public bool[] ���ã��bool = new bool[20];
    public int ���ã�ⳡ = 0;
    public int ��������Ƚ�� = 2;
    public int �ɸ����ִ�Ƚ�� = 5;
    public �Ҹ������ũ��Ʈ �Ҹ������ũ��������;
    public Sprite ���丮�̹���;
    public Sprite ����ī�̹���;
    public Sprite ���̹���;
    public Sprite ����ī�̹���;
    public Sprite �����̹���;
    public Sprite ��Ű�̹���;
    public Sprite ��Ű���̹���;
    public Sprite �Ŀ��̹���;
    public Sprite ���޳��̹���;
    
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �ɸ����̸�.text = �ɸ����̸�����;

            ������.text = "We're sorry, but this\n feature requires video\n viewing.\n\nvideo free : " + ��������Ƚ�� + " count\nCharacter Max : " + �ɸ����ִ�Ƚ�� + "\n\nPremium : Infinity";
            ������.text = "Yes";
            ������ƴϿ�.text = "No";
            �������â�ؽ�Ʈ.text = "Ad loading failed";
            �������âȮ���ؽ�Ʈ.text = "O K";
            
            ��������.text = "We're sorry, but this\n feature requires video\n viewing.";
            ��������.text = "Yes";
            ��������ƴϿ�.text = "No";
        }
        else
        {
            ������.text = "���ã�� ����� ����ϱ� ����\n���� ��û�Ͻðڽ��ϱ�?" +
                "\n\n������� : �����û�� "+ ��������Ƚ��+"ȸ"+"\n�ɸ��ʹ� �ִ� : "+�ɸ����ִ�Ƚ��+"��\n\n�����̾� : ������";
        }

        DataBase �ӽõ�Ÿ���̽� = DataBase.Instance();
        �ӽõ�Ÿ���̽�.���̺��̸� = ���̺꿡�Ѱ����ɸ����̸�;
       ���۱���.Instance().�����̸� = �ɸ����̸�����;

        �ӽõ�Ÿ���̽�.��ã��ҷ�����();
        if (�������Լ� == ������.����)
        {
            �ӽõ�Ÿ���̽�.�ҷ�����();

            ����ȭ = �ӽõ�Ÿ���̽�.����.���ã���ڱ��ȣ����Ʈ;

            for (int i = 0; i < ����ȭ.Count; i++)
            {
                int ang = ����ȭ[i];
                GameObject �θ� = ����[ang].transform.parent.gameObject;
                �θ�.gameObject.transform.SetSiblingIndex(i);
                �θ�.transform.GetChild(1).gameObject.GetComponent<â���ų�����>().��ǥǥ��();
            }
            if (PlayerPrefs.GetInt("EnKo") != 0)
            {
                for (int i = 0; i < �Ҹ������ũ��������.Ŭ����.Length; i++)
                {
                    ����[i].text = ����[i].GetComponent<KoenS>().En;
                }
            }
            else
            {
                for (int i = 0; i < �Ҹ������ũ��������.Ŭ����.Length; i++)
                {
                    ����[i].text = ����[i].GetComponent<KoenS>().Ko;
                }
            }
        }
        else
        {
            int ii = �ӽõ�Ÿ���̽�.�����.����������.Count;
            if (ii < 1)
            {
                for (int i = ii; i < 35; i++)
                {
                    ����[i].gameObject.transform.parent.gameObject.SetActive(false);
                }
                return;
            }
            if (ii > 0)
            {
                if (ii >35)
                {
                    ii = 35;
                }
                if (PlayerPrefs.GetInt("EnKo") != 0)
                {
                    �ɸ����̸�.text = �ɸ����̸�.text + "     "+ii+" / "+"35";
                }
                else
                {
                    �ɸ����̸�.text = ���̺꿡�Ѱ����ɸ����̸� + "     " + ii + " / " + "35";
                }
                �Ҹ������ũ��������.Ŭ���� = new AudioClip[ii];
                �Ҹ������ũ��������.Ŭ��������� = new TextAsset[ii];
                if (ii < 35)
                {
                    for (int i = ii; i < 35; i++)
                    {
                       ����[i].gameObject.transform.parent.gameObject.SetActive(false);
                    }
                }
                for (int i = 0; i < ii; i++)
                {
                    if (PlayerPrefs.GetInt("EnKo") != 0)
                    {
                        ����[i].text = �ӽõ�Ÿ���̽�.��ã��������ȭ��[i];
                    }
                    else
                    {
                        ����[i].text = �ӽõ�Ÿ���̽�.��ã�ѱ����ȭ��[i];
                    }
                    ����[i].fontSize = �ӽõ�Ÿ���̽�.��ã����ũ�⵿��ȭ��[i];
                  RectTransform ��ȸ�뷺Ʈ = ����[i].transform.parent.gameObject.GetComponent<RectTransform>();
                    ��ȸ�뷺Ʈ.sizeDelta = new Vector2(��ȸ�뷺Ʈ.sizeDelta.x, �ӽõ�Ÿ���̽�.��ã���̵���ȭ��[i]);
                    �Ҹ������ũ��������.Ŭ����[i] = �ӽõ�Ÿ���̽�.��ã���������Ʈ����ȭ��[i];
                    �Ҹ������ũ��������.Ŭ���������[i] = �ӽõ�Ÿ���̽�.��ã���������븮��Ʈ����ȭ��[i];
                    string ��ȸ���̸� = �ӽõ�Ÿ���̽�.��ã�̸�����ȭ��[i];
                    GameObject ��ȸ��θ� = ����[i].gameObject.transform.parent.gameObject;
                 
                    switch (��ȸ���̸�)
                    {
                        case "���丮" :
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ���丮�̹���;
                            break;
                        case "����ī":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ����ī�̹���;
                            break;
                        case "��":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ���̹���;
                            break;
                        case "����ī":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ����ī�̹���;
                            break;
                        case "����":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = �����̹���;
                            break;
                        case "��Ű":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ��Ű�̹���;
                            break;
                        case "�Ŀ�":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = �Ŀ��̹���;
                            break;
                        case "��Ű��":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ��Ű���̹���;
                            break;
                        case "���޳�":
                            ��ȸ��θ�.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = ���޳��̹���;
                            break;
                        default:
                            break;
                    }
                    //����[i].transform.parent.gameObject.GetComponent<RectTransform>().sizeDelta.y = DataBase.Instance().��ã���̵���ȭ��[i];
                    /*int ang = ����ȭ[i];
                    GameObject �θ� = ����[ang].transform.parent.gameObject;
                    �θ�.gameObject.transform.SetSiblingIndex(i);
                    �θ�.transform.GetChild(1).gameObject.GetComponent<â���ų�����>().��ǥǥ��();*/
                }
            }

        }
    }
    public void �쳩(int ������ȣ)
    {
        ���ã�ⳡ = ����ȭ.Count;
        ����ȭ.Add(������ȣ);
        DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ = ����ȭ;
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
            int nIndex = ����ȭ.IndexOf(������ȣ);
            ����ȭ.RemoveAt(nIndex);
         
        }
        DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ = ����ȭ;
        DataBase.Instance().�����ϱ�();

    }
    public void �ʱ�ȭ��()
    {
        DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ = ���۵���ȭ;
        DataBase.Instance().�����ϱ�();
    }

}
