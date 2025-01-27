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
        //InvokeRepeating = 호출을 할 수 있는 기능을 담당하는 함수
        //0초에서 시작해서 1초마다 생성
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
        //square라는 변수 안에 Instantiate(생성)할 수 있는 코드
    }    

    public void GameOver()
    {
        Time.timeScale = 0.0f; //timeScale이 0이다 = 끝났다.
        nowScore.text = time.ToString("N2");
        endPanel.SetActive(true); //체크박스가 해지되어 있는걸 키는 거니까 true
        
    }
}
