using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abb : MonoBehaviour
{
    public int ���� = 1;
    public List<int> ����ȭ = new List<int>();
    public void Start()
    {
        DataBase.Instance().���̺��̸� = "����";
        DataBase.Instance().�ҷ�����();
       ����ȭ = DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ;
    }

    public void �þ��()
    {
        ����ȭ.Add(����);
        ����+= 2;
        DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ = ����ȭ;
        DataBase.Instance().�����ϱ�();
        print(DataBase.Instance().����.���ã���ڱ��ȣ����Ʈ.Count);
        /*DataBase.instance.����.���ã���ڱ��ȣ����Ʈ.Add(����);
        ����++;
        print(DataBase.instance.����.���ã���ڱ��ȣ����Ʈ);*/
    }
    public void �پ����()
    {

    }
}
