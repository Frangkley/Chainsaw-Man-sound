using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 게임매니저스크립 : MonoBehaviour {

    private enum State { 메인, 메인아님, /*채널쓰리*/}
    [SerializeField]
    private State currentState = State.메인아님;

  
    public void 메인으로()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("메인");
    }
    public void 덴지방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("덴지");
    }
    public void 죠타로방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("덴지");
    }
    public void 죠스케방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("죠스케");
    }
   
    public void 디오방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("디오");
    }
    public void 카쿄인방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("카쿄인");
    }
    public void 키라방()
    {
        배너광고.Instance().숨기자();
        SceneManager.LoadScene("키라");
    }
    // Use this for initialization
    void Start () {
        if (currentState == State.메인아님)
        {
            슈퍼광고.Instance().로딩확인();
        }
	}
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(currentState == State.메인)
            {
                Application.Quit();
            }
            else
            {
                배너광고.Instance().숨기자();
                SceneManager.LoadScene("메인");
            }
        }
	}
}
