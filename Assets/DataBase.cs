using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
using System.IO;

class Detaj
{
    public string language;
}*/
public class DataBase : MonoBehaviour
{/*
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

    Detaj ��� = new Detaj() {language = "�ѱ���"};
    public string path�н�;
    public string filename = "save";
    // Start is called before the first frame update
    private void Awake()
    {
        #region �̱���
        DontDestroyOnLoad(this.gameObject);
        #endregion
        path�н� = Application.persistentDataPath + "/";
    }
    void Start()
    {
     
    }
    public void �����ϱ�()
    {
        string ���̽������� = JsonUtility.ToJson(���);
        File.WriteAllText(path�н� + filename, ���̽�������);
    }
    public void �ҷ�����()
    {
        string ���̽������� =File.ReadAllText(path�н� + filename);
        ��� = JsonUtility.FromJson<Detaj>(���̽�������);
    }*/
}
