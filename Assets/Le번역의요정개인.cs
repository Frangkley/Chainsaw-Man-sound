using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Le번역의요정개인: MonoBehaviour
{
    public Text 케릭터이름;
    public string 케릭터이름영문;
    public Text[] 대사들;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            케릭터이름.text = 케릭터이름영문;
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void 즐겨찾기()
    {

    }
}
