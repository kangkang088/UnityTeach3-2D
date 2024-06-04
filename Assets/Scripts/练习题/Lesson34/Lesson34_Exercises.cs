using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson34_Exercises : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("isMoving", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isMoving", false);
        }
        if (animator.GetBool("isMoving"))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
    }
}
