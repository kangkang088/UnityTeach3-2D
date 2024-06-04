using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson61 : MonoBehaviour
{
    private Animator animator;
    public Transform targetPos;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
            //参数一：目标位置
            //参数二：目标角度
            //参数三：匹配的骨骼位置
            //参数四：位置角度权重
            //参数五：开始位移动作的百分比
            //参数六：结束位移动作的百分比
            
        }
    }
    private void MatchTarget()
    {
        animator.MatchTarget(targetPos.position, targetPos.rotation, AvatarTarget.LeftFoot, new MatchTargetWeightMask(Vector3.one, 1), 0.4f, 0.64f);
    }
    
}
