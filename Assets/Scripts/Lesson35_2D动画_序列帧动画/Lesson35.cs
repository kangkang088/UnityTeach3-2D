using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson35 : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer sr;
    private float time = 0;
    private int nowIndex = 0;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sr = this.GetComponent<SpriteRenderer>();
        sr.sprite = sprites[nowIndex];
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 0.03f)
        {
            nowIndex++;
            if (nowIndex >= sprites.Length)
            {
                nowIndex = 0;
            }
            sr.sprite = sprites[nowIndex];
            time = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isDown", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isDown", false);
        }
    }
}
