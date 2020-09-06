using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float width = 1;

    Rigidbody2D rb;

    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.right * width;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullut")
        {
            GameObject c_coin = Instantiate(coin);
            coin.transform.position = transform.position;
            Destroy(c_coin, 5);
        }
    }
}
