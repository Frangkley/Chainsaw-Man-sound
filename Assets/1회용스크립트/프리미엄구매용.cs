using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 프리미엄구매용: MonoBehaviour
{
    public GameObject[] 성공시열것들;
    public GameObject[] 실패시열것들;
    // Start is called before the first frame update
    public GameObject[] 닫을것들;

    public void 전부닫아주세요()
    {
        for (int i = 0; i < 닫을것들.Length; i++)
        {
            닫을것들[i].SetActive(true);
        }
    }
    public void 전부열어주세요()
    {
        for (int i = 0; i < 성공시열것들.Length; i++)
        {
            성공시열것들[i].SetActive(true);
        }
    }
    public void 구매성공시()
    {
        DataBase.Instance().모드종류 = DataBase.프리미엄모드.프리미엄;
        DataBase.Instance().프리미엄저장하기();
        배너광고.Instance().숨기자();
        for (int i = 0; i < 성공시열것들.Length; i++)
        {
            성공시열것들[i].SetActive(true);
        }
        for (int i = 0; i < 닫을것들.Length; i++)
        {
            닫을것들[i].SetActive(false);
        }
    }
    public void 실패시()
    {
        for (int i = 0; i < 실패시열것들.Length; i++)
        {
            실패시열것들[i].SetActive(true);
        }
        for (int i = 0; i < 닫을것들.Length; i++)
        {
            닫을것들[i].SetActive(false);
        }
    }

}
