using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 소리동기화용 : MonoBehaviour
{
    public string 이건되냐;
    public string[] 이름들;
    public List<int> 번호들 = new List<int>();
    public enum 방종류 { 개인, 즐겨찾기 }
    public 방종류 방종류함수 = 방종류.개인;
    public DataBase 데타베이스시작용;
    public List <AudioClip> 영번소리들클립 = new List<AudioClip>();
    public TextAsset[] 영번소리들에셋;
    public AudioClip[] 일번소리들클립;
    public TextAsset[] 일번소리들에셋;
    public AudioClip[] 이번소리들클립;
    public TextAsset[] 이번소리들에셋;
    public AudioClip[] 삼번소리들클립;
    public TextAsset[] 삼번소리들에셋;
    public AudioClip[] 사번소리들클립;
    public TextAsset[] 사번소리들에셋;
    public AudioClip[] 오번소리들클립;
    public TextAsset[] 오번소리들에셋;
    public AudioClip[] 육번소리들클립;
    public TextAsset[] 육번소리들에셋;
    public AudioClip[] 칠번소리들클립;
    public TextAsset[] 칠번소리들에셋;
    public int 실험용숫자 = 0;
    // Start is called before the first frame update
    void Start()
    {
        데타베이스시작용 = DataBase.Instance();
        if (이름들.Length != 데타베이스시작용.소리개수버그감지.Length)
        {
            Debug.Log("이름이랑 소리개수다름");
            데타베이스시작용.소리개수버그감지 = new int[이름들.Length];
        }
        /*
            데타베이스시작용.소리개수버그감지[0] = 영번소리들클립.Count;
            데타베이스시작용.소리개수버그감지[1] = 일번소리들클립.Length;
            데타베이스시작용.소리개수버그감지[3] = 삼번소리들클립.Length;
            데타베이스시작용.소리개수버그감지[2] = 이번소리들클립.Length;
            데타베이스시작용.소리개수버그감지[4] = 사번소리들클립.Length;
        /*
            데타베이스시작용.소리개수버그감지[5] = 오번소리들클립.Length;
            데타베이스시작용.소리개수버그감지[6] = 육번소리들클립.Length;
            데타베이스시작용.소리개수버그감지[7] = 칠번소리들클립.Length;
        */
        for (int i = 0; i < 데타베이스시작용.즐찾삭제정보용.Count; i++)
        {
            string 이름 = 데타베이스시작용.즐찾이름동기화용[i];
            int bar = 데타베이스시작용.즐찾번호동기화용[i];
            int ii = 0;
            for (ii = 0; ii < 이름들.Length; ii++)
            {
                if (이름들[ii] == 이름)
                {
                    번호들.Add(ii);
                    break;
                }
            }
            실험용숫자 = ii;
            
            switch (ii)
            {
                case 0:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(영번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(영번소리들에셋[bar]);
                    break;
                case 1:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(일번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(일번소리들에셋[bar]);
                    break;
                case 2:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(이번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(이번소리들에셋[bar]);
                    break;
                case 3:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(삼번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(삼번소리들에셋[bar]);
                    break;
                case 4:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(사번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(사번소리들에셋[bar]);
                    break;
                case 5:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(오번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(오번소리들에셋[bar]);
                    break;
                case 6:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(육번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(육번소리들에셋[bar]);
                    break;
                case 7:
                    데타베이스시작용.즐찾오디오리스트동기화용.Add(칠번소리들클립[bar]);
                    데타베이스시작용.즐찾오디오저장용리스트동기화용.Add(칠번소리들에셋[bar]);
                    break;
                default:
                    break;
            }
        }
    }
}
