using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
  // [ExecuteInEditMode]
public class ��ư��������: MonoBehaviour
{
    public Button ��;
    public void Awake()
    {
        �� = gameObject.GetComponent<Button>();
        ��.targetGraphic = gameObject.GetComponent<Image>();
    }
}
