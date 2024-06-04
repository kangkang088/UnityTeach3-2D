using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson60 : MonoBehaviour
{
    private Animator animator;
    public Transform pos;
    public Transform pos2;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnAnimatorIK(int layerIndex)
    {
        //头部IK相关

        //设置 头部看向 的权重
        animator.SetLookAtWeight(1,0.5f, 0.5f);
        animator.SetLookAtPosition(pos.position);

        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        animator.SetIKPosition(AvatarIKGoal.RightHand, pos2.position);
        animator.SetIKRotation(AvatarIKGoal.RightHand, pos2.rotation);
    }
}
