using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public GameObject bullut;
    float speed = 5;
    bool vec = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");              // 入力デバイスの水平軸をhで定義
        float v = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += h * Time.deltaTime * speed;
        transform.position = pos;
        Vector3 scale = transform.localScale;
        if (h < 0)
        {
            scale.x = Mathf.Abs(scale.x);
            transform.localScale = scale;
            vec = false;
        }
        else if (h > 0)
        {

            scale.x = -Mathf.Abs(scale.x);
            transform.localScale = scale;
            vec = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject c_obj = Instantiate(bullut);
            Rigidbody2D rb = c_obj.GetComponent<Rigidbody2D>();
            if (vec)
            {
                c_obj.transform.position = transform.position + Vector3.right;
                rb.velocity = Vector2.right * 10;
            }
            else
            {
                c_obj.transform.position = transform.position + Vector3.left;
                rb.velocity = Vector2.left * 10;
            }
            Destroy(c_obj,5);
        }
    }
    float Hugou(float n)
    {
        return n / Mathf.Abs(n);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject);
            ScoreManager.Instance.AddScore();
        }
    }

}
