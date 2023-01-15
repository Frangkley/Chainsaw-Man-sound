using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F«¡∑π¿” : MonoBehaviour
{
    public int Frame;
    // Start is called before the first frame update
    void Start()
    {
        if (Frame < 300)
        {
            Frame = 300;
        }
        Application.targetFrameRate = Frame;
    }

}
