using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(1, 5)]
    float speed;

    Rigidbody2D rb;
    PolygonCollider2D coll;

    float movex;
    float movey;

    Vector2 move;

    bool facingLeft;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
    }
    void Update()
    {
        if (movex > 0 && facingLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingLeft = false;
        }
        if (movex < 0 && facingLeft)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingLeft = true;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        movex = Input.GetAxis("Horizontal");
        movey = Input.GetAxis("Vertical");
        move = new Vector2(movex * speed, movey * speed);
        rb.AddForce(move);
    }
}