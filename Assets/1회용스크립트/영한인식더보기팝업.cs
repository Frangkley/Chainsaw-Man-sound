using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �����νĴ������˾� : MonoBehaviour
{
    public GameObject �����˾�;
    public GameObject �ѱ��˾�;
    // Start is called before the first frame update

    public void �˾��ѱ�()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �����˾�.SetActive(true);
          
        }
        else
        {
            �ѱ��˾�.SetActive(true);
        }
    }
}
