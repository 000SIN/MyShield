using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(3.0f, 5.0f);

        transform.position = new Vector2 (x, y);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector2(size, size);

        
    }

    void Update()
    {
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }
    //요 업데이트 부분은 숙제로 추가한 부분

    private void OnCollisionEnter2D(Collision2D collision)
    {
    
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collisonEnter player");
            GameManager.Instance.GameOver();
        }
    }
}
