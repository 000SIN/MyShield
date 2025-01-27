using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject square;
    public GameObject endPanel;
    public Text timeTxt;
    public Text nowScore;

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
        InvokeRepeating("MakeSquare", 0f, 1f);
        //InvokeRepeating = ȣ���� �� �� �ִ� ����� ����ϴ� �Լ�
        //0�ʿ��� �����ؼ� 1�ʸ��� ����
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
    }

    void MakeSquare()
    {
        Instantiate(square);
        //square��� ���� �ȿ� Instantiate(����)�� �� �ִ� �ڵ�
    }    

    public void GameOver()
    {
        Time.timeScale = 0.0f; //timeScale�� 0�̴� = ������.
        nowScore.text = time.ToString("N2");
        endPanel.SetActive(true); //üũ�ڽ��� �����Ǿ� �ִ°� Ű�� �Ŵϱ� true
        
    }
}
