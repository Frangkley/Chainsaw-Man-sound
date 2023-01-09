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

    Detaj 언어 = new Detaj() {language = "한국어"};
    public string path패스;
    public string filename = "save";
    // Start is called before the first frame update
    private void Awake()
    {
        #region 싱글톤
        DontDestroyOnLoad(this.gameObject);
        #endregion
        path패스 = Application.persistentDataPath + "/";
    }
    void Start()
    {
     
    }
    public void 저장하기()
    {
        string 제이슨데이터 = JsonUtility.ToJson(언어);
        File.WriteAllText(path패스 + filename, 제이슨데이터);
    }
    public void 불러오기()
    {
        string 제이슨데이터 =File.ReadAllText(path패스 + filename);
        언어 = JsonUtility.FromJson<Detaj>(제이슨데이터);
    }*/
}
