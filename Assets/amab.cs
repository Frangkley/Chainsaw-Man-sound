using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amab : MonoBehaviour
{
    public void 애미애비뒤진저장()
    {
        DataBase.Instance().언어.즐겨찾기통 = "시발?";
       DataBase.Instance().저장하기();
    }
    public void 애미애비뒤진불러오기()
    {
        DataBase.Instance().불러오기();
        print(DataBase.Instance().언어.즐겨찾기통);
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
