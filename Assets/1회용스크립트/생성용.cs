using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ������: MonoBehaviour
{
    public GameObject[] ��ư��;
    public GameObject ���׸�;
    public int �迭��;
    public Vector3 originScale;
    public int ������ = 1;
    void Start()
    {
        ������ = 3;
        �迭�� = ��ư��.Length;
        for(int i= 0; i<�迭��;)
        {
            GameObject ���� = Instantiate(���׸�, transform.localPosition, transform.localRotation) as GameObject;
            originScale = ����.transform.localScale;
            ����.transform.SetParent(��ư��[i].gameObject.transform);
            ����.transform.localScale = originScale;
            i++;
        }
    }

}
