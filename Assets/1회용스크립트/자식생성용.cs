using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[ExecuteInEditMode]
public class 磊侥积己侩: MonoBehaviour
{
    public GameObject 橇府普眠啊;
    public Vector3 originScale;
    // Start is called before the first frame update
    public void Awake()
    {
        GameObject 积己 = Instantiate(橇府普眠啊, transform.localPosition, transform.localRotation) as GameObject;
        originScale = 积己.transform.localScale;
        积己.transform.SetParent(gameObject.transform);
        积己.transform.localScale = originScale;
    }

}
