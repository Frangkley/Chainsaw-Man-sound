using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo2 : MonoBehaviour
{
    public enum State { ü�μҸ�, ��ġ, ���� }
    public State ���̸� = State.ü�μҸ�;
    public int ���尪 = 1;
    public Text ������ư;
    public Text ��Ű����ư;
    public Text ��Ű��ư;
    public Text �Ŀ���ư;
    public Text ����;
    public GameObject ����Vǥ��;
    public GameObject ������Vǥ��;
    public GameObject ���â;
    public GameObject �ٸ��ۺ�������;
    public Text ������������;
    public Text �������׳���;
    public string subject = "��ġ���� ����������";
    public string body = "https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US";
    public void Awake()
    {
        if (���̸� != State.����)
        {
            if (!PlayerPrefs.HasKey("EnKo"))
            {
                PlayerPrefs.SetInt("EnKo", 1);
                ���â�ѱ�();
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("EnKo") != 0)
        {
            �������();
        }

    }
    public void ShareApp()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            // SoundManager.instance.PlayExf(0);
            StartCoroutine(ShareAndroidText());
        }
    }
    public void �������()
    {
        switch (���̸�)
        {
            case State.ü�μҸ�:
                ������ư.text = "Denji";
                ��Ű��ư.text = "Aki";
                ��Ű����ư.text = "Makima";
                �Ŀ���ư.text = "Power";
                ����.text = "Chainsaw\nMan";
                ����.fontSize = 15;
                ������������.text = "Notice";
                �������׳���.text = "These are the lines\nfrom the contents up\nto episode 3.\n\nWe will update\nwhen the number of\ndownloads increases!";
                ���尪 = 1;
                �ٸ��ۺ�������.SetActive(false);
                subject = "Chainsaw Man Characters sound";
                break;
            case State.��ġ:
                ������ư.text = "Hitori";
                ��Ű��ư.text = "Aki";
                ��Ű����ư.text = "Makima";
                �Ŀ���ư.text = "Power";
                ����.text = "Bocchi the\nRock!";
                ����.fontSize = 15;
                ������������.text = "Notice";
                �������׳���.text = "These are the lines\nfrom the contents up\nto episode 3.\n\nWe will update\nwhen the number of\ndownloads increases!";
                ���尪 = 1;
                �ٸ��ۺ�������.SetActive(false);
                subject = "Bocchi the Rock! Characters sound";
                break;
            default:
                break;
        }
    }
    public void �ѱ۹���()
    {
        switch (���̸�)
        {
            case State.ü�μҸ�:
                ������ư.text = "�� ��";
                ��Ű��ư.text = "�� Ű";
                ��Ű����ư.text = "��Ű��";
                �Ŀ���ư.text = "�Ŀ�";
                ����.text = "ü�μ� ��";
                ����.fontSize = 22;
                ������������.text = "�� �� �� ��";
                �������׳���.text = "���� 3ȭ������ ���뿡�� \n ���� ���� �Դϴ�.\n(��Ű �� ����)\n\n�ٿ�ε���� �þ��\n������Ʈ�ϰڽ��ϴ�!";
                subject = "ü�μҸ� ����������";
                �ٸ��ۺ�������.SetActive(true);
                break;
            case State.��ġ:
                ������ư.text = "���丮";
                ��Ű��ư.text = "�� Ű";
                ��Ű����ư.text = "��Ű��";
                �Ŀ���ư.text = "�Ŀ�";
                ����.text = "��ġ �� ��!";
                ����.fontSize = 22;
                ������������.text = "�� �� �� ��";
                �������׳���.text = "���� 3ȭ������ ���뿡�� \n ���� ���� �Դϴ�.\n(��Ű �� ����)\n\n�ٿ�ε���� �þ��\n������Ʈ�ϰڽ��ϴ�!";
                subject = "��ġ �� ��!";
                �ٸ��ۺ�������.SetActive(true);
                break;
            default:
                break;
        }
    }
    IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device
#if UNITY_ANDROID
        //Reference of AndroidJavaClass class for intent
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        //Reference of AndroidJavaObject class for intent
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
        //call setAction method of the Intent object created


        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        //set the type of sharing that is happening
        intentObject.Call<AndroidJavaObject>("setType", "text/plain");
        //add data to be passed to the other activity i.e., the data to be sent
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
        //intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TITLE"), "Text Sharing ");
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
        //get the current activity
        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
        //start the activity by sending the intent data
        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share Via");
        currentActivity.Call("startActivity", jChooser);
#endif
    }
    public void ���Ҹ�ũ()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US");
    }
    public void �ѱ���()
    {
        ���尪 = 0;
        ����Vǥ��.SetActive(true);
        ������Vǥ��.SetActive(false);
    }
    public void ����()
    {
        ���尪 = 1;
        ����Vǥ��.SetActive(false);
        ������Vǥ��.SetActive(true);
    }
    public void OK()
    {
        if (���尪 == 0)
        {
            �ѱ۹���();
        }
        else
        {
            �������();
        }
        PlayerPrefs.SetInt("EnKo", ���尪);
        ���â.SetActive(false);
    }
    public void ���â�ѱ�()
    {
        ���â.SetActive(true);
        if (���尪 == 0)
        {
            ����Vǥ��.SetActive(true);
            ������Vǥ��.SetActive(false);
        }
        else
        {
            ����Vǥ��.SetActive(false);
            ������Vǥ��.SetActive(true);
        }
    }
}
