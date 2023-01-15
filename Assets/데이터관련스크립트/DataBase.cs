using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class Detaj
{
    public string ���ã���� = "�⺻��";
    public List<int> ���ã���ڱ��ȣ����Ʈ = new List<int>();
}
public class DataBase : MonoBehaviour
{
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
    public Detaj ��� = new Detaj() /*{language = "�ѱ���"}*/;
    public string ���ã��������� = "save";
    public string ���̺��̸� = "�ɸ���";
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
        ���ã��������� = Application.persistentDataPath + "/";
       //File.Delete(���ã��������� + newSlot.ToString());
    }
    public void �����ϱ�()
    {
        string ���̽������� = JsonUtility.ToJson(���);
        File.WriteAllText(���ã��������� + ���̺��̸�,���̽�������);
       // print(���̽�������);
    }
    public void �ҷ�����()
    {
        if (File.Exists(���ã��������� + ���̺��̸�))
        {
            string ���̽������� = File.ReadAllText(���ã��������� + ���̺��̸�);
            Debug.Log(���ã��������� + ���̺��̸�);
            ��� = JsonUtility.FromJson<Detaj>(���̽�������);
        }
        else
        {
            �����ϱ�();
        }
    
        //print(���);
    }
}
