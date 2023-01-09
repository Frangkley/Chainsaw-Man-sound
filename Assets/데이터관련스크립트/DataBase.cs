using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

class Detaj
{
    public string language;
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

    Detaj ��� = new Detaj() {language = "�ѱ���"};
    public string path�н�;
    public string filename = "save";
    public int newSlot;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
      
        path�н� = Application.persistentDataPath + "/";

    }
    public void �����ϱ�()
    {
        string ���̽������� = JsonUtility.ToJson(���);
        File.WriteAllText(path�н� + filename + newSlot.ToString(), ���̽�������);
    }
    public void �ҷ�����()
    {
        string ���̽������� =File.ReadAllText(path�н� + filename + newSlot.ToString());
        ��� = JsonUtility.FromJson<Detaj>(���̽�������);
    }
}
