using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class Le번역의요정개인: MonoBehaviour
{
    public Text 케릭터이름;
    public string 케릭터이름영문;
    public Text[] 대사들;
    public bool[] 즐겨찾기bool;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            케릭터이름.text = 케릭터이름영문;
        }
        /*
        for (int i = 0; i < 대사들.Length; i++)
        {
            if (File.Exists(DataBase.instance.path패스 + $"{i}"))
            {
                즐겨찾기bool[i] = true;
            }
            else
            {

            }
        }*/

    }
    // Start is called before the first frame update
   
  
}
