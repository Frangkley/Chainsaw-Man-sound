using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamBab : MonoBehaviour
{
    public Animator Me;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("true") != 1)
        {
            PlayerPrefs.SetInt("true", 1);
            Me.SetTrigger("New");
        }
        else
        {
            Me.SetTrigger("Off");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
