using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class �Ҹ�����ȭ�� : MonoBehaviour
{
    public string �̰ǵǳ�;
    public string[] �̸���;
    public List<int> ��ȣ�� = new List<int>();
    public enum ������ { ����, ���ã�� }
    public ������ �������Լ� = ������.����;
    public DataBase ��Ÿ���̽����ۿ�;
    public List <AudioClip> �����Ҹ���Ŭ�� = new List<AudioClip>();
    public TextAsset[] �����Ҹ��鿡��;
    public AudioClip[] �Ϲ��Ҹ���Ŭ��;
    public TextAsset[] �Ϲ��Ҹ��鿡��;
    public AudioClip[] �̹��Ҹ���Ŭ��;
    public TextAsset[] �̹��Ҹ��鿡��;
    public AudioClip[] ����Ҹ���Ŭ��;
    public TextAsset[] ����Ҹ��鿡��;
    public AudioClip[] ����Ҹ���Ŭ��;
    public TextAsset[] ����Ҹ��鿡��;
    public AudioClip[] �����Ҹ���Ŭ��;
    public TextAsset[] �����Ҹ��鿡��;
    public AudioClip[] �����Ҹ���Ŭ��;
    public TextAsset[] �����Ҹ��鿡��;
    public AudioClip[] ĥ���Ҹ���Ŭ��;
    public TextAsset[] ĥ���Ҹ��鿡��;
    public int �������� = 0;
    // Start is called before the first frame update
    void Start()
    {
        ��Ÿ���̽����ۿ� = DataBase.Instance();
        if (�̸���.Length != ��Ÿ���̽����ۿ�.�Ҹ��������װ���.Length)
        {
            Debug.Log("�̸��̶� �Ҹ������ٸ�");
            ��Ÿ���̽����ۿ�.�Ҹ��������װ��� = new int[�̸���.Length];
        }
        /*
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[0] = �����Ҹ���Ŭ��.Count;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[1] = �Ϲ��Ҹ���Ŭ��.Length;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[3] = ����Ҹ���Ŭ��.Length;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[2] = �̹��Ҹ���Ŭ��.Length;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[4] = ����Ҹ���Ŭ��.Length;
        /*
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[5] = �����Ҹ���Ŭ��.Length;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[6] = �����Ҹ���Ŭ��.Length;
            ��Ÿ���̽����ۿ�.�Ҹ��������װ���[7] = ĥ���Ҹ���Ŭ��.Length;
        */
        for (int i = 0; i < ��Ÿ���̽����ۿ�.��ã����������.Count; i++)
        {
            string �̸� = ��Ÿ���̽����ۿ�.��ã�̸�����ȭ��[i];
            int bar = ��Ÿ���̽����ۿ�.��ã��ȣ����ȭ��[i];
            int ii = 0;
            for (ii = 0; ii < �̸���.Length; ii++)
            {
                if (�̸���[ii] == �̸�)
                {
                    ��ȣ��.Add(ii);
                    break;
                }
            }
            �������� = ii;
            
            switch (ii)
            {
                case 0:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(�����Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(�����Ҹ��鿡��[bar]);
                    break;
                case 1:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(�Ϲ��Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(�Ϲ��Ҹ��鿡��[bar]);
                    break;
                case 2:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(�̹��Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(�̹��Ҹ��鿡��[bar]);
                    break;
                case 3:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(����Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(����Ҹ��鿡��[bar]);
                    break;
                case 4:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(����Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(����Ҹ��鿡��[bar]);
                    break;
                case 5:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(�����Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(�����Ҹ��鿡��[bar]);
                    break;
                case 6:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(�����Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(�����Ҹ��鿡��[bar]);
                    break;
                case 7:
                    ��Ÿ���̽����ۿ�.��ã���������Ʈ����ȭ��.Add(ĥ���Ҹ���Ŭ��[bar]);
                    ��Ÿ���̽����ۿ�.��ã���������븮��Ʈ����ȭ��.Add(ĥ���Ҹ��鿡��[bar]);
                    break;
                default:
                    break;
            }
        }
    }
}
