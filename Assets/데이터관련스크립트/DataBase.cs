using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class Detaj
{
    public string 즐겨찾기통 = "기본값";
    public List<int> 즐겨찾기자기번호리스트 = new List<int>();
}
public class DataBase : MonoBehaviour
{
    #region 싱글톤
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
    public Detaj 언어 = new Detaj() /*{language = "한국어"}*/;
    public string 즐겨찾기저장공간 = "save";
    public string 세이브이름 = "케릭터";
    // Start is called before the first frame update
    private void Awake()
    {
        // SoundManager 인스턴스가 이미 있는지 확인, 이 상태로 설정
        if (instance == null)
            instance = this;

        // 인스턴스가 이미 있는 경우 오브젝트 제거
        else if (instance != this)
            Destroy(gameObject);

        // 이렇게 하면 다음 scene으로 넘어가도 오브젝트가 사라지지 않습니다.
        DontDestroyOnLoad(gameObject);
        즐겨찾기저장공간 = Application.persistentDataPath + "/";
       //File.Delete(즐겨찾기저장공간 + newSlot.ToString());
    }
    public void 저장하기()
    {
        string 제이슨데이터 = JsonUtility.ToJson(언어);
        File.WriteAllText(즐겨찾기저장공간 + 세이브이름,제이슨데이터);
       // print(제이슨데이터);
    }
    public void 불러오기()
    {
        if (File.Exists(즐겨찾기저장공간 + 세이브이름))
        {
            string 제이슨데이터 = File.ReadAllText(즐겨찾기저장공간 + 세이브이름);
            Debug.Log(즐겨찾기저장공간 + 세이브이름);
            언어 = JsonUtility.FromJson<Detaj>(제이슨데이터);
        }
        else
        {
            저장하기();
        }
    
        //print(언어);
    }
}
