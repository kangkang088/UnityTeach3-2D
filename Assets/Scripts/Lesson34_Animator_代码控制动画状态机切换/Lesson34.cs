using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson34 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Change", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Change", false);
        }
    }
}
