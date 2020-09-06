using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Rigidbody2D rb;

    public float coinSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1.0f, 1.0f), 1.0f);
        rb.velocity = rb.velocity.normalized * coinSpeed;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    rb.velocity = Vector2.zero;
    //}
}
