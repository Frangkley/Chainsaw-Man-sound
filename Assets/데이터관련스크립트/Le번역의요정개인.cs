using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le�����ǿ�������: MonoBehaviour
{
    public Text �ɸ����̸�;
    public string �ɸ����̸�����;
    public Text[] ����;
    public bool[] ���ã��bool;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �ɸ����̸�.text = �ɸ����̸�����;
        }
        /*
        for (int i = 0; i < ����.Length; i++)
        {
            if (File.Exists(DataBase.instance.path�н� + $"{i}"))
            {
                ���ã��bool[i] = true;
            }
            else
            {

            }
        }*/

    }
    // Start is called before the first frame update
   
  
}
