using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  //   [ExecuteInEditMode]
public class �ڽĻ�����: MonoBehaviour
{
    public GameObject �������߰�;
    public Vector3 originScale;
    // Start is called before the first frame update
    public void Awake()
    {
        �ڽĹ�ȣ����();
    }
    public void �ܼ�����()
    {
        GameObject ���� = Instantiate(�������߰�, transform.localPosition, transform.localRotation) as GameObject;
        originScale = ����.transform.localScale;
        ����.transform.SetParent(gameObject.transform);
        ����.transform.localScale = originScale;
    }
    public void �ڽĹ�ȣ����()
    {
        GameObject ���� = Instantiate(�������߰�, transform.localPosition, transform.localRotation) as GameObject;
        originScale = ����.transform.localScale;
        ����.transform.SetParent(gameObject.transform);
        ����.transform.localScale = originScale;
        int ��ȣ = gameObject.GetComponent<�ڱ��ȣ>().��ȣ;
        â���ų����� â���� = ����.GetComponent<â���ų�����>();
        â����.�ڱ��ȣ = ��ȣ;
    }
}
