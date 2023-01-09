using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class 크기관리자 : MonoBehaviour
{

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void FirstInitialize()
    {
        Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);
    }
    /* private static void FirstInitialize()
     {
         Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);
     }
     */
}