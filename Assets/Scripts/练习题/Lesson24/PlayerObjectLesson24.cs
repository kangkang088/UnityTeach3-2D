using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectLesson24 : MonoBehaviour
{
    public float moveSpeed = 3;
    private SpriteRenderer sr;
    private Rigidbody2D rigidBody2D;
    private float h;
    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
        rigidBody2D = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        //跳跃
        rigidBody2D.velocity = new Vector2(h * moveSpeed, rigidBody2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody2D.AddForce(Vector2.up * 300);
        }
        //面朝向改变
        if (h < 0)
            sr.flipX = true;
        else if (h > 0)
            sr.flipY = false;
    }
}
