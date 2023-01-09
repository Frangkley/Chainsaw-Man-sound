using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class 자식삭제좀 : MonoBehaviour
{
    public GameObject 제거용오브젝트;
    public bool 한번만 = false;
    // Start is called before the first frame update
    private void Awake()
    {

        if (!한번만)
        {
            한번만 = true;
            제거용오브젝트 = gameObject.transform.GetChild(2).gameObject;
            Destroy(제거용오브젝트);
        }

    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
