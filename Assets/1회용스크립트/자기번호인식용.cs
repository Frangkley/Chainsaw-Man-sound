using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[ExecuteInEditMode]
public class �ڱ��ȣ�νĿ�: MonoBehaviour
{
    public void Start()
    {
        GameObject Hong = gameObject.transform.parent.gameObject;
        int ��ȣ = Hong.GetComponent<�ڱ��ȣ>().��ȣ;
        â���ų����� â���� = gameObject.GetComponent<â���ų�����>();
        â����.�ڱ��ȣ = ��ȣ;

        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
