using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public float moveSpeed = 5;
    private float h;
    private SpriteRenderer sr;
    private Rigidbody2D rigidbody2Ds;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2Ds = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxisRaw("Horizontal");
        animator.SetInteger("xSpeed", (int)h);
        animator.SetInteger("ySpeed", Mathf.CeilToInt(rigidbody2Ds.velocity.y));
        //this.transform.Translate(5 * Time.deltaTime * Vector3.right * h);
        if (h != 0)
            rigidbody2Ds.velocity = new Vector2(h * moveSpeed, rigidbody2Ds.velocity.y);
        //控制翻转
        if (h < 0)
            sr.flipX = true;
        else if (h > 0)
            sr.flipX = false;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>("BulletObj"), this.transform.position + new Vector3(sr.flipX ? -0.3f : 0.3f, 0.5f, 0), Quaternion.identity);
            obj.GetComponent<BulletObj>().ChangeMoveDir(sr.flipX ? Vector3.left : Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            rigidbody2Ds.AddForce(Vector2.up * 300);
        }
    }
}
