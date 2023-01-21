using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  // [ExecuteInEditMode]
public class 버튼동적변경: MonoBehaviour
{
    public Button 응;
    public void Awake()
    {
        응 = gameObject.GetComponent<Button>();
        응.targetGraphic = gameObject.GetComponent<Image>();
    }
}
