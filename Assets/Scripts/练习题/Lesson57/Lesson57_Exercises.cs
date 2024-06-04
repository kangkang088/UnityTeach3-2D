using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson57_Exercises : MonoBehaviour
{
    private Animator animator;
    private float deValue = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        animator.SetFloat("Speed", Input.GetAxis("Vertical") * deValue);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            deValue = 1.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            deValue = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
    }
    private void JumpOver()
    {
    }
}
