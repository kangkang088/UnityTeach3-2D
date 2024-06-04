using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson55_Exercises : MonoBehaviour
{
    private Animator animator;
    public float roundSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Speed", (int)Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
        }
        this.transform.Rotate(Vector3.up * Time.deltaTime * Input.GetAxisRaw("Horizontal") * roundSpeed);
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("Fall");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetLayerWeight(animator.GetLayerIndex("Hurt"), 1);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetLayerWeight(animator.GetLayerIndex("Hurt"), 0);
        }

    }
    private void JumpOver()
    {
        animator.SetBool("Jump", false);
    }
}
