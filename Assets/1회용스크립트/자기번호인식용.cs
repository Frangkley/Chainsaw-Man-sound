using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[ExecuteInEditMode]
public class 자기번호인식용: MonoBehaviour
{
    public void Start()
    {
        GameObject Hong = gameObject.transform.parent.gameObject;
        int 번호 = Hong.GetComponent<자기번호>().번호;
        창열거나닫자 창열닫 = gameObject.GetComponent<창열거나닫자>();
        창열닫.자기번호 = 번호;

        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
