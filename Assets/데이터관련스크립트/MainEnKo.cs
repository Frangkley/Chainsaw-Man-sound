using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainEnKo : MonoBehaviour
{
    public enum State { ü�μҸ�, ��ġ, ���� }
    public State ���̸� = State.ü�μҸ�;
    public int ���尪 = 1;
    public Text ������ư;
    public Text ��Ű����ư;
    public Text ��Ű��ư;
    public Text �Ŀ���ư;
    public Text ����;
    public Text ���ã��;
    public GameObject ����Vǥ��;
    public GameObject ������Vǥ��;
    public GameObject ���â;
    public GameObject �ٸ��ۺ�������;
    public Text ������������;
    public Text �������׳���;
    [TextArea]
    public string �������׳���ٿ��ֱ��ѱ���;
    [TextArea]
    public string �������׳���ٿ��ֱ⿵��;
    public Text �����˾��ؽ�Ʈ;
    public Text �����˾��ؽ�Ʈ��;
    public Text �����˾��ؽ�Ʈ�ƴϿ�;
    public Text �����˾��ؽ�Ʈ�����̾�;
    public Text �����̾�����;
    public Text �����̾�����;
    public Text �����̾���ҹ�ư;
    public Text �����̾����Ź�ư;
    public Text �������г���;
    public Text �������г���Ȯ��;
    public Text ������������;
    public Text ������������Ȯ��;
    public GameObject �����̾����ž�����;
    public GameObject ���������˾�â;
    public string subject = "ü�μҸ� ����������";
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
        if (���̸� != State.����)
        {
            ���尪 = PlayerPrefs.GetInt("EnKo");
            if (���尪 == 0)
            {
                �ѱ۷�();
            }
            else
            {
                �����();
            }
        }
        if (DataBase.Instance().������� == DataBase.�����̾����.�Ϲ�)
        {
            �����̾����ž�����.SetActive(true);
        }
        if (DataBase.Instance().���������˾���������� == true)
        {
            ���������˾�â.SetActive(true);
            DataBase.Instance().���������˾���������� = false;
        }
    }
    public void �����()
    {
        �������();
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
                ���ã��.text = "Favorites";
                subject = "Chainsaw Man Characters sound";
             

                break;
            case State.��ġ:
                ������ư.text = "Hitori";
                ��Ű��ư.text = "Nijika";
                ��Ű����ư.text = "Ryo";
                �Ŀ���ư.text = "Seika";
                ����.text = "Bocchi the\nRock!";
                ����.fontSize = 15;
                ������������.text = "Notice";
                �������׳���.text = "These are the lines\nfrom the contents up\nto episode 2.\n\nWe will update\nwhen the number of\ndownloads increases!";
                ���ã��.text = "Favorites";
                subject = "Bocchi the Rock! Characters sound";
                break;
            default:
                break;
        }
    }
    public void �ѱ۰���()
    {

        ���ã��.text = "���ã��";
        //�ٸ��ۺ�������.SetActive(true);
        �����˾��ؽ�Ʈ.text = "���ã��� �����̾� �����Դϴ�\n\n���� ������ ������ ������\n������ ��û�� �ʿ��մϴ�";
        �����˾��ؽ�Ʈ��.text = "������ ��û(����)";
        �����˾��ؽ�Ʈ��.fontSize = 15;
        �����˾��ؽ�Ʈ�ƴϿ�.text = "���";
        �����˾��ؽ�Ʈ�����̾�.text = "�����̾� �̿��";
        �����̾����Ź�ư.text = "�����̾� �̿��";
        �����̾�����.text = "-���� ����(�ٿ�,���� ������)\n-�ɸ��� ���ã��\n  ���Ѿ���\n-���ã���\n  �ִ� : 35";
        �����̾�����.text = "�����̾� ����";
        �����̾���ҹ�ư.text = "�� ��";
        �������г���.text = "���� ���";
        �������г���Ȯ��.text = "Ȯ��";
        ������������.text = "���� ����";
        ������������Ȯ��.text = "Ȯ��";

    }
    public void �������()
    {
        ���尪 = 1;
        //�ٸ��ۺ�������.SetActive(false);
        �����˾��ؽ�Ʈ.text = "We're sorry, but this\n feature requires video\n viewing.";
        �����˾��ؽ�Ʈ��.text = "GET FOR FREE (AD)";
        �����˾��ؽ�Ʈ��.fontSize = 13;
        �����˾��ؽ�Ʈ�ƴϿ�.text = "CANCLE";
        �����˾��ؽ�Ʈ�����̾�.text = "GET PREMIUM";
        �����̾����Ź�ư.text = "GET PREMIUM";
        �����̾�����.text = "-No AD\n-No bookmark\n  restrictions\n-FavoritesRoom \n  Max : 35";
        �����̾�����.text = "PREMIUM Ver";
        �����̾���ҹ�ư.text = "CANCLE";
        �������г���.text = "CANCLE";
        �������г���Ȯ��.text = "O K";
        ������������.text = "The bill has\n been paid";
        ������������Ȯ��.text = "O K";

    }
    public void �ѱ۷�()
    {
        �ѱ۰���();
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
                �������׳���.text = �������׳���ٿ��ֱ��ѱ���;
                subject = "ü�μҸ� ����������";
                break;
            case State.��ġ:
                ������ư.text = "���丮";
                ��Ű��ư.text = "����ī";
                ��Ű����ư.text = "��";
                �Ŀ���ư.text = "����ī";
                ����.text = "��ġ �� ��!";
                ����.fontSize = 22;
                ������������.text = "�� �� �� ��";
                �������׳���.text = "���� 2ȭ������ ���뿡�� \n ���� ���� �Դϴ�. \n\n�ٿ�ε���� �þ��\n������Ʈ�ϰڽ��ϴ�!";
                subject = "��ġ �� ��!";
                break;
            default:
                break;
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

    IEnumerator ShareAndroidText()
    {
        yield return new WaitForEndOfFrame();
        //execute the below lines if being run on a Android device
#if UNITY_ANDROID
        
      
        //ü�μҸ�
        /**/
        //��ġ
       
        switch (���̸�)
        {
            case State.ü�μҸ�:
                if (���尪 == 0)
                {
                    body = "https://play.google.com/store/apps/details?id=com.bef.chainsawmansound";
                }
                else
                {
                    body = "https://play.google.com/store/apps/details?id=com.bef.chainsawmansound&hl=ko&gl=US";
                }
                break;
            case State.��ġ:
                if (���尪 == 0)
                {
                    body = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
                }
                else
                {
                    body = "https://play.google.com/store/apps/details?id=com.Bef.Bocchisound";
                }
                break;
            case State.����:
                body = "https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US";
                break;
            default:
                break;
        }
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
        //������
        //Application.OpenURL("https://play.google.com/store/apps/details?id=com.frang.jojosound&hl=ko&gl=US");

        //ü�μҸ�
        if (���尪 == 0)
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.bef.chainsawmansound");
        }
        else
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.bef.chainsawmansound&hl=ko&gl=US");
        }
        //��ġ
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
            �ѱ۷�();
        }
        else
        {
            �����();
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
