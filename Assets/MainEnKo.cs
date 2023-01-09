using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public Text 덴지버튼;
    public Text 마키마버튼;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0);
        {
            덴지버튼.text = "Denji";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
