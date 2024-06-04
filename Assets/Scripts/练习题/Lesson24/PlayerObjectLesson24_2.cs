using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjectLesson24_2 : MonoBehaviour
{
    private float h;
    private float v;
    public float moveSpeed = 5;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if (h < 0)
            sr.flipX = true;
        else if (h > 0)
            sr.flipX = false;
        //水平方向
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * h);
        //竖直方向
        this.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * v);
    }
}
