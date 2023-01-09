using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("삭제용", 0.3f);
    }

    public void 삭제용()
    {
        SceneManager.LoadScene("메인");
    }
}
