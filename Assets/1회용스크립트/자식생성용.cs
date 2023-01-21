using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  //   [ExecuteInEditMode]
public class 자식생성용: MonoBehaviour
{
    public GameObject 프리팹추가;
    public Vector3 originScale;
    // Start is called before the first frame update
    public void Awake()
    {
        자식번호까지();
    }
    public void 단순생성()
    {
        GameObject 생성 = Instantiate(프리팹추가, transform.localPosition, transform.localRotation) as GameObject;
        originScale = 생성.transform.localScale;
        생성.transform.SetParent(gameObject.transform);
        생성.transform.localScale = originScale;
    }
    public void 자식번호까지()
    {
        GameObject 생성 = Instantiate(프리팹추가, transform.localPosition, transform.localRotation) as GameObject;
        originScale = 생성.transform.localScale;
        생성.transform.SetParent(gameObject.transform);
        생성.transform.localScale = originScale;
        int 번호 = gameObject.GetComponent<자기번호>().번호;
        창열거나닫자 창열닫 = 생성.GetComponent<창열거나닫자>();
        창열닫.자기번호 = 번호;
    }
}
