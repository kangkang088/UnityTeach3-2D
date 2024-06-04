﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson62_StateMachineBehaviour : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("HumanoidIdle"))
            Debug.Log("进入HumanoidIdle状态了");
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("HumanoidIdle"))
            Debug.Log("退出HumanoidIdle状态了");
    }
    public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateIK(animator, stateInfo, layerIndex);
    }
    public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateMove(animator, stateInfo, layerIndex);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.IsName("HumanoidIdle"))
            Debug.Log("处于HumanoidIdle状态了");
    }
    public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
            Debug.Log("进入New StateMachine子状态机了");
    }
    public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    {
        base.OnStateMachineExit(animator, stateMachinePathHash);
    }
}
