using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Le�����ǿ�������: MonoBehaviour
{
    public Text �ɸ����̸�;
    public string �ɸ����̸�����;
    public Text[] ����;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �ɸ����̸�.text = �ɸ����̸�����;
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ���ã��()
    {

    }
}
