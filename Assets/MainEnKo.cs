using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public Text ������ư;
    public Text ��Ű����ư;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0);
        {
            ������ư.text = "Denji";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
