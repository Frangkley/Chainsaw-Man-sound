using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class Detaj
{
    public string ���ã���� = "�⺻��";
    public List<int> ���ã���ڱ��ȣ����Ʈ = new List<int>();
  
}
public class Detajb
{
    public List<string> ���������� = new List<string>();
   // public List<AudioClip> ���������Ʈ = new List<AudioClip>();
   // public List<TextAsset> ���������븮��Ʈ = new List<TextAsset>();
    public List<float> ���� = new List<float>();
    [TextArea]
    public List<string> �ѱ��� = new List<string>();
    [TextArea]
    public List<string> �����ؽ�Ʈ = new List<string>();
    public List<int> ����ũ�� = new List<int>();
    public List<string> �̸� = new List<string>();
    public List<int> ��ȣ = new List<int>();
}
public class Pre
{
    public bool �����̾� = false;
    public float �ʱ�ȭ���� = 0;
}
public class DataBase : MonoBehaviour
{
    public int[] �Ҹ��������װ���;
    public string[] �������̸�������;
    public �Ҹ������ũ��Ʈ �Ҹ������ũ��;
    public int �Ҹ����� = 0;
    public List<string> ��ã���������� = new List<string>();
    public List<AudioClip> ��ã���������Ʈ����ȭ�� = new List<AudioClip>();
    public List<TextAsset> ��ã���������븮��Ʈ����ȭ�� = new List<TextAsset>();
    public List<float> ��ã���̵���ȭ�� = new List<float>();
    [TextArea]
    public List<string> ��ã�ѱ����ȭ�� = new List<string>();
    [TextArea]
    public List<string> ��ã��������ȭ�� = new List<string>();
    public List<int> ��ã����ũ�⵿��ȭ�� = new List<int>();
    public List<string> ��ã�̸�����ȭ�� = new List<string>();
    public List<int> ��ã��ȣ����ȭ�� = new List<int>();
    #region �̱���
    public static DataBase instance;
    public static DataBase Instance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<DataBase>();

            if (instance == null)
            {
                GameObject container = new GameObject("DataController");

                instance = container.AddComponent<DataBase>();
            }


        }
        return instance;
    }
    #endregion
    public Detaj ���� = new Detaj() /*{language = "�ѱ���"}*/;
    public Detajb ����� = new Detajb();
    public Pre �����̾����� = new Pre();
    public float �ʱ�ȭ���� = 0f;
    public string ���ã��������� = "save";
    public string ���̺��̸� = "�ɸ���";
    public enum �����̾���� { �Ϲ�, �����̾� }
    public �����̾���� ������� = �����̾����.�Ϲ�;
    public enum �����ڸ�� { �Ϲ�, ������ }
    public �����ڸ�� ������� = �����ڸ��.�Ϲ�;
    public bool ���۽��ѹ��� = false;
    public bool ���������˾���������� = false;
    public float �������;
    // Start is called before the first frame update
    private void Awake()
    {
        // SoundManager �ν��Ͻ��� �̹� �ִ��� Ȯ��, �� ���·� ����
        if (instance == null)
            instance = this;

        // �ν��Ͻ��� �̹� �ִ� ��� ������Ʈ ����
        else if (instance != this)
            Destroy(gameObject);

        // �̷��� �ϸ� ���� scene���� �Ѿ�� ������Ʈ�� ������� �ʽ��ϴ�.
        DontDestroyOnLoad(gameObject);
        if (���۽��ѹ��� == true)
        {
            return;
        }
        ���ã��������� = Application.persistentDataPath + "/";
        �����̾��ҷ�����();
        �ʱ�ȭ���� = �����̾�����.�ʱ�ȭ����;
        if (�ʱ�ȭ���� == 0)
        {
            �����̾����� = new Pre();
            ��������ʱ�ȭ();
            �ʱ�ȭ���� = 1;
            �����̾�����.�ʱ�ȭ���� = �ʱ�ȭ����;
            bool Ʈ�簪 = �����̾�����.�����̾�;
            �����̾�����.�����̾� = Ʈ�簪;
            string ���̽������� = JsonUtility.ToJson(�����̾�����);
            File.WriteAllText(���ã��������� + "Pre", ���̽�������);

            Debug.Log("�ʱ�ȭ����");
        }
        ��ã��ҷ�����();
        bool ��ȸ��Ұ� = false;
        ��ȸ��Ұ� = �����̾�����.�����̾�;
        if (�����̾�����.�����̾� == true)
        {
            ������� = �����̾����.�����̾�;
        }
        ���۽��ѹ��� = true;
        float bar = PlayerPrefs.GetFloat("Ver");

        if (bar < �������)
        {
            ���������˾���������� = true;
            PlayerPrefs.SetFloat("Ver", �������);
            int iiii = PlayerPrefs.GetInt("��ãȽ��");
            PlayerPrefs.SetInt("��ãȽ��", iiii+4);
        }
        int iiiii = PlayerPrefs.GetInt("��ãȽ��");
        ///����Ʈ;
        if (iiiii >= 10)
        {
            PlayerPrefs.SetInt("��ãȽ��", 9);
        }
        //File.Delete(���ã��������� + newSlot.ToString());
    }
    public void Start()
    {
        
        /*�ǰڳİ�.Add(�����);
        ���.�Ǹ����������� = �ǰڳİ�;
        ���������();*/
    }
    /*
    public void ������߰�(int ������ȣ, int �۾�ũ��, string �ѱ���, string ����, float ����)
    {

}*/
    public void ��ã������()
    {
        string ���̽������� = JsonUtility.ToJson(�����);
        File.WriteAllText(���ã��������� + "���ã��", ���̽�������);
    }
    public void ��ã������(int ������ȣ)
    {
        if (��ã����������.Count == 1)
        {
            ��ã����������.Clear();
            ��ã����ũ�⵿��ȭ��.Clear();
            ��ã���̵���ȭ��.Clear();
            ��ã��������ȭ��.Clear();
            ��ã��ȣ����ȭ��.Clear();
            ��ã�ѱ����ȭ��.Clear();
            ��ã�̸�����ȭ��.Clear();
            ��ã���������Ʈ����ȭ��.Clear();
            ��ã���������븮��Ʈ����ȭ��.Clear();
        }
        else
        {
            int nIndex = ��ã����������.IndexOf(���̺��̸� + ������ȣ);
            if (nIndex != -1)
            {
                ��ã����������.RemoveAt(nIndex);
                ��ã����ũ�⵿��ȭ��.RemoveAt(nIndex);
                ��ã���̵���ȭ��.RemoveAt(nIndex);
                ��ã��������ȭ��.RemoveAt(nIndex);
                ��ã��ȣ����ȭ��.RemoveAt(nIndex);
                ��ã�ѱ����ȭ��.RemoveAt(nIndex);
                ��ã�̸�����ȭ��.RemoveAt(nIndex);
                ��ã���������Ʈ����ȭ��.RemoveAt(nIndex);
                ��ã���������븮��Ʈ����ȭ��.RemoveAt(nIndex);
            }
        }
        �����.����ũ�� = ��ã����ũ�⵿��ȭ��;
        �����.���������� = ��ã����������;
        �����.���� = ��ã���̵���ȭ��;
        �����.�����ؽ�Ʈ = ��ã��������ȭ��;
        �����.�ѱ��� = ��ã�ѱ����ȭ��;
        �����.��ȣ = ��ã��ȣ����ȭ��;
        �����.�̸� = ��ã�̸�����ȭ��;
        ��ã������();
    }
    public void ��������ʱ�ȭ()
    {
        bool �Ұ� = false;
        for (int i = 0; i < �������̸�������.Length; i++)
        {
            if (File.Exists(���ã��������� + �������̸�������[i]))
            {
                File.Delete(���ã��������� + �������̸�������[i]);
                �Ұ� = true;
                ���������˾���������� = true;
            }
        }
        if (File.Exists(���ã��������� + "���ã��"))
        {
            File.Delete(���ã��������� + "���ã��");
        }
        if (�Ұ� == true)
        {
            int ��ãȽ�� = PlayerPrefs.GetInt("��ãȽ��");
            PlayerPrefs.SetInt("��ãȽ��", ��ãȽ�� + 8);
        }
       
    }
    public void �����ϱ�()
    {
        string ���̽������� = JsonUtility.ToJson(����);
        File.WriteAllText(���ã��������� + ���̺��̸�,���̽�������);
       // print(���̽�������);
    }
    public void �����̾������ϱ�()
    {
        �����̾����� = new Pre();
        bool Ʈ�簪 = true;
        �����̾�����.�����̾� = Ʈ�簪;
        �����̾�����.�ʱ�ȭ���� = �ʱ�ȭ����;
        string ���̽������� = JsonUtility.ToJson(�����̾�����);
        File.WriteAllText(���ã��������� + "Pre", ���̽�������);
    }
    
    public void �����̾��ҷ�����()
    {
        if (File.Exists(���ã��������� + "Pre"))
        {
            string ���̽������� = File.ReadAllText(���ã��������� + "Pre");
           // Debug.Log(���ã��������� + "Pre");
            �����̾����� = JsonUtility.FromJson<Pre>(���̽�������);
        }
        else
        {
            �����̾����� = new Pre();
            string ���̽������� = JsonUtility.ToJson(�����̾�����);
            File.WriteAllText(���ã��������� + "Pre", ���̽�������);
        }
    }
    public void ���������ϱ�()
    {
        ���� = new Detaj();
        string ���̽������� = JsonUtility.ToJson(����);
        File.WriteAllText(���ã��������� + ���̺��̸�, ���̽�������);
    }
    public void ��ã��ҷ�����()
    {
        if (File.Exists(���ã��������� + "���ã��"))
        {
            string ���̽������� = File.ReadAllText(���ã��������� + "���ã��");
           // Debug.Log(���ã��������� + "���ã��");
            ����� = JsonUtility.FromJson<Detajb>(���̽�������);
           ��ã����ũ�⵿��ȭ�� = �����.����ũ��;
            ��ã���������� = �����.����������;
             ��ã���̵���ȭ��= �����.����;
            ��ã��������ȭ�� = �����.�����ؽ�Ʈ;
             ��ã�ѱ����ȭ�� = �����.�ѱ���;
             ��ã��ȣ����ȭ�� = �����.��ȣ;
            ��ã�̸�����ȭ�� = �����.�̸�;
        }
        else
        {
            ��ã������();
        }
    }
    public void �ҷ�����()
    {
        if (File.Exists(���ã��������� + ���̺��̸�))
        {
            string ���̽������� = File.ReadAllText(���ã��������� + ���̺��̸�);
           // Debug.Log(���ã��������� + ���̺��̸�);
            ���� = JsonUtility.FromJson<Detaj>(���̽�������);
        }
        else
        {
            ���������ϱ�();
        }
    
        //print(���);
    }
}
