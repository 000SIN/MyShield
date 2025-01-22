using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
        transform.position = mousePos;
        //게임 오브젝트의 위치를 마우스의 월드 좌표로 설정하는 코드
        //즉, 마우스가 움직이는 대로 게임 오브젝트도 따라 움직이게 된다.
    }
}
