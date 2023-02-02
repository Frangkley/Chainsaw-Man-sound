using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class Detaj
{
    public string 즐겨찾기통 = "기본값";
    public List<int> 즐겨찾기자기번호리스트 = new List<int>();
  
}
public class Detajb
{
    public List<string> 삭제정보용 = new List<string>();
   // public List<AudioClip> 오디오리스트 = new List<AudioClip>();
   // public List<TextAsset> 오디오저장용리스트 = new List<TextAsset>();
    public List<float> 높이 = new List<float>();
    [TextArea]
    public List<string> 한국어 = new List<string>();
    [TextArea]
    public List<string> 영문텍스트 = new List<string>();
    public List<int> 글자크기 = new List<int>();
    public List<string> 이름 = new List<string>();
    public List<int> 번호 = new List<int>();
}
public class Pre
{
    public bool 프리미엄 = false;
    public float 초기화버전 = 0;
}
public class DataBase : MonoBehaviour
{
    public int[] 소리개수버그감지;
    public string[] 삭제용이름종류들;
    public 소리재생스크립트 소리재생스크립;
    public int 소리개수 = 0;
    public List<string> 즐찾삭제정보용 = new List<string>();
    public List<AudioClip> 즐찾오디오리스트동기화용 = new List<AudioClip>();
    public List<TextAsset> 즐찾오디오저장용리스트동기화용 = new List<TextAsset>();
    public List<float> 즐찾높이동기화용 = new List<float>();
    [TextArea]
    public List<string> 즐찾한국어동기화용 = new List<string>();
    [TextArea]
    public List<string> 즐찾영문동기화용 = new List<string>();
    public List<int> 즐찾글자크기동기화용 = new List<int>();
    public List<string> 즐찾이름동기화용 = new List<string>();
    public List<int> 즐찾번호동기화용 = new List<int>();
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
    public Detaj 언어원 = new Detaj() /*{language = "한국어"}*/;
    public Detajb 언어투 = new Detajb();
    public Pre 프리미엄여부 = new Pre();
    public float 초기화버전 = 0f;
    public string 즐겨찾기저장공간 = "save";
    public string 세이브이름 = "케릭터";
    public enum 프리미엄모드 { 일반, 프리미엄 }
    public 프리미엄모드 모드종류 = 프리미엄모드.일반;
    public enum 관리자모드 { 일반, 관리자 }
    public 관리자모드 관리모드 = 관리자모드.일반;
    public bool 시작시한번만 = false;
    public bool 공지사항팝업띄울지여부 = false;
    public float 현재버전;
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
        if (시작시한번만 == true)
        {
            return;
        }
        즐겨찾기저장공간 = Application.persistentDataPath + "/";
        프리미엄불러오기();
        초기화버전 = 프리미엄여부.초기화버전;
        if (초기화버전 == 0)
        {
            프리미엄여부 = new Pre();
            모든저장초기화();
            초기화버전 = 1;
            프리미엄여부.초기화버전 = 초기화버전;
            bool 트루값 = 프리미엄여부.프리미엄;
            프리미엄여부.프리미엄 = 트루값;
            string 제이슨데이터 = JsonUtility.ToJson(프리미엄여부);
            File.WriteAllText(즐겨찾기저장공간 + "Pre", 제이슨데이터);

            Debug.Log("초기화했음");
        }
        즐찾용불러오기();
        bool 일회용불값 = false;
        일회용불값 = 프리미엄여부.프리미엄;
        if (프리미엄여부.프리미엄 == true)
        {
            모드종류 = 프리미엄모드.프리미엄;
        }
        시작시한번만 = true;
        float bar = PlayerPrefs.GetFloat("Ver");

        if (bar < 현재버전)
        {
            공지사항팝업띄울지여부 = true;
            PlayerPrefs.SetFloat("Ver", 현재버전);
            int iiii = PlayerPrefs.GetInt("즐찾횟수");
            PlayerPrefs.SetInt("즐찾횟수", iiii+4);
        }
        int iiiii = PlayerPrefs.GetInt("즐찾횟수");
        ///리미트;
        if (iiiii >= 10)
        {
            PlayerPrefs.SetInt("즐찾횟수", 9);
        }
        //File.Delete(즐겨찾기저장공간 + newSlot.ToString());
    }
    public void Start()
    {
        
        /*되겠냐고.Add(실험용);
        언어.되면고생을안하지 = 되겠냐고;
        실험용저장();*/
    }
    /*
    public void 오디오추가(int 받은번호, int 글씨크기, string 한국어, string 영어, float 높이)
    {

}*/
    public void 즐찾용저장()
    {
        string 제이슨데이터 = JsonUtility.ToJson(언어투);
        File.WriteAllText(즐겨찾기저장공간 + "즐겨찾기", 제이슨데이터);
    }
    public void 즐찾용제거(int 받은번호)
    {
        if (즐찾삭제정보용.Count == 1)
        {
            즐찾삭제정보용.Clear();
            즐찾글자크기동기화용.Clear();
            즐찾높이동기화용.Clear();
            즐찾영문동기화용.Clear();
            즐찾번호동기화용.Clear();
            즐찾한국어동기화용.Clear();
            즐찾이름동기화용.Clear();
            즐찾오디오리스트동기화용.Clear();
            즐찾오디오저장용리스트동기화용.Clear();
        }
        else
        {
            int nIndex = 즐찾삭제정보용.IndexOf(세이브이름 + 받은번호);
            if (nIndex != -1)
            {
                즐찾삭제정보용.RemoveAt(nIndex);
                즐찾글자크기동기화용.RemoveAt(nIndex);
                즐찾높이동기화용.RemoveAt(nIndex);
                즐찾영문동기화용.RemoveAt(nIndex);
                즐찾번호동기화용.RemoveAt(nIndex);
                즐찾한국어동기화용.RemoveAt(nIndex);
                즐찾이름동기화용.RemoveAt(nIndex);
                즐찾오디오리스트동기화용.RemoveAt(nIndex);
                즐찾오디오저장용리스트동기화용.RemoveAt(nIndex);
            }
        }
        언어투.글자크기 = 즐찾글자크기동기화용;
        언어투.삭제정보용 = 즐찾삭제정보용;
        언어투.높이 = 즐찾높이동기화용;
        언어투.영문텍스트 = 즐찾영문동기화용;
        언어투.한국어 = 즐찾한국어동기화용;
        언어투.번호 = 즐찾번호동기화용;
        언어투.이름 = 즐찾이름동기화용;
        즐찾용저장();
    }
    public void 모든저장초기화()
    {
        bool 불값 = false;
        for (int i = 0; i < 삭제용이름종류들.Length; i++)
        {
            if (File.Exists(즐겨찾기저장공간 + 삭제용이름종류들[i]))
            {
                File.Delete(즐겨찾기저장공간 + 삭제용이름종류들[i]);
                불값 = true;
                공지사항팝업띄울지여부 = true;
            }
        }
        if (File.Exists(즐겨찾기저장공간 + "즐겨찾기"))
        {
            File.Delete(즐겨찾기저장공간 + "즐겨찾기");
        }
        if (불값 == true)
        {
            int 즐찾횟수 = PlayerPrefs.GetInt("즐찾횟수");
            PlayerPrefs.SetInt("즐찾횟수", 즐찾횟수 + 8);
        }
       
    }
    public void 저장하기()
    {
        string 제이슨데이터 = JsonUtility.ToJson(언어원);
        File.WriteAllText(즐겨찾기저장공간 + 세이브이름,제이슨데이터);
       // print(제이슨데이터);
    }
    public void 프리미엄저장하기()
    {
        프리미엄여부 = new Pre();
        bool 트루값 = true;
        프리미엄여부.프리미엄 = 트루값;
        프리미엄여부.초기화버전 = 초기화버전;
        string 제이슨데이터 = JsonUtility.ToJson(프리미엄여부);
        File.WriteAllText(즐겨찾기저장공간 + "Pre", 제이슨데이터);
    }
    
    public void 프리미엄불러오기()
    {
        if (File.Exists(즐겨찾기저장공간 + "Pre"))
        {
            string 제이슨데이터 = File.ReadAllText(즐겨찾기저장공간 + "Pre");
           // Debug.Log(즐겨찾기저장공간 + "Pre");
            프리미엄여부 = JsonUtility.FromJson<Pre>(제이슨데이터);
        }
        else
        {
            프리미엄여부 = new Pre();
            string 제이슨데이터 = JsonUtility.ToJson(프리미엄여부);
            File.WriteAllText(즐겨찾기저장공간 + "Pre", 제이슨데이터);
        }
    }
    public void 최초저장하기()
    {
        언어원 = new Detaj();
        string 제이슨데이터 = JsonUtility.ToJson(언어원);
        File.WriteAllText(즐겨찾기저장공간 + 세이브이름, 제이슨데이터);
    }
    public void 즐찾용불러오기()
    {
        if (File.Exists(즐겨찾기저장공간 + "즐겨찾기"))
        {
            string 제이슨데이터 = File.ReadAllText(즐겨찾기저장공간 + "즐겨찾기");
           // Debug.Log(즐겨찾기저장공간 + "즐겨찾기");
            언어투 = JsonUtility.FromJson<Detajb>(제이슨데이터);
           즐찾글자크기동기화용 = 언어투.글자크기;
            즐찾삭제정보용 = 언어투.삭제정보용;
             즐찾높이동기화용= 언어투.높이;
            즐찾영문동기화용 = 언어투.영문텍스트;
             즐찾한국어동기화용 = 언어투.한국어;
             즐찾번호동기화용 = 언어투.번호;
            즐찾이름동기화용 = 언어투.이름;
        }
        else
        {
            즐찾용저장();
        }
    }
    public void 불러오기()
    {
        if (File.Exists(즐겨찾기저장공간 + 세이브이름))
        {
            string 제이슨데이터 = File.ReadAllText(즐겨찾기저장공간 + 세이브이름);
           // Debug.Log(즐겨찾기저장공간 + 세이브이름);
            언어원 = JsonUtility.FromJson<Detaj>(제이슨데이터);
        }
        else
        {
            최초저장하기();
        }
    
        //print(언어);
    }
}
