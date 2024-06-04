using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson56 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        animator.SetLayerWeight(animator.GetLayerIndex("MyLayer2"), 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
