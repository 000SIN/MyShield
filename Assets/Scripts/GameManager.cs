using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject square;
    public GameObject endPanel;
    public Text timeTxt;
    public Text nowScore;
    public Text bestScore;

    bool isPlay = true;

    float time = 0.0f;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("MakeSquare", 0f, 1f);
        //InvokeRepeating = ȣ���� �� �� �ִ� ����� ����ϴ� �Լ�
        //0�ʿ��� �����ؼ� 1�ʸ��� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            time += Time.deltaTime;
            timeTxt.text = time.ToString("N2");
        }
    }

    void MakeSquare()
    {
        Instantiate(square);
        //square��� ���� �ȿ� Instantiate(����)�� �� �ִ� �ڵ�
    }    

    public void GameOver()
    {
        isPlay = false;
        Time.timeScale = 0.0f; //timeScale�� 0�̴� = ������.
        nowScore.text = time.ToString("N2");
        
        //�ְ������� �ִٸ�
        if(PlayerPrefs.HasKey("bestScore"))
        {
            float best = PlayerPrefs.GetFloat("bestScore");
            //�ְ����� < ���� ����
            if(best < time)
            {
                //���� ������ �ְ� ������ �����Ѵ�.
                PlayerPrefs.SetFloat("bestScore", time);
                bestScore.text = time.ToString("N2");
            }
            else
            {
                bestScore.text = best.ToString("N2");
            }
        }
        else
        {
            PlayerPrefs.SetFloat("bestScore", time);
            bestScore.text = time.ToString("N2");
        }
            
            
        //�ְ������� ���ٸ�
            //���� ������ �����Ѵ�.

        endPanel.SetActive(true); //üũ�ڽ��� �����Ǿ� �ִ°� Ű�� �Ŵϱ� true
        
    }
}
