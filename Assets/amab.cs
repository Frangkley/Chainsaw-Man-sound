using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amab : MonoBehaviour
{
    public void �ֹֺ̾��������()
    {
        DataBase.Instance().���.���ã���� = "�ù�?";
       DataBase.Instance().�����ϱ�();
    }
    public void �ֹֺ̾�����ҷ�����()
    {
        DataBase.Instance().�ҷ�����();
        print(DataBase.Instance().���.���ã����);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
