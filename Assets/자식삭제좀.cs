using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class �ڽĻ����� : MonoBehaviour
{
    public GameObject ���ſ������Ʈ;
    public bool �ѹ��� = false;
    // Start is called before the first frame update
    private void Awake()
    {

        if (!�ѹ���)
        {
            �ѹ��� = true;
            ���ſ������Ʈ = gameObject.transform.GetChild(2).gameObject;
            Destroy(���ſ������Ʈ);
        }

    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
