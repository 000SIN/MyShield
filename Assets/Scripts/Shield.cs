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
        //���� ������Ʈ�� ��ġ�� ���콺�� ���� ��ǥ�� �����ϴ� �ڵ�
        //��, ���콺�� �����̴� ��� ���� ������Ʈ�� ���� �����̰� �ȴ�.
    }
}
