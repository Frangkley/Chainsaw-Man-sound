using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KoenS : MonoBehaviour
{
    [TextArea]
    public string Ko;
    [TextArea]
    public string En;
    public int 글씨크기 = 15;
    public Text 본인텍스트;
    // Start is called before the first frame update

    public void Awake()
    {/*
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            본인텍스트.text = En;
        }*/
    }
}
