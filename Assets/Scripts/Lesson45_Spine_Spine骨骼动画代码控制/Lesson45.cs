using Spine;
using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson45 : MonoBehaviour
{
    [SpineAnimation]
    public string jumpName;
    [SpineBone]
    public string boneName;
    [SpineSlot]
    public string slotName;
    [SpineAttachment]
    public string attachmentName;
    private SkeletonAnimation sa;
    // Start is called before the first frame update
    void Start()
    {
        sa = this.GetComponent<SkeletonAnimation>();
        //sa.loop = false;
        //sa.AnimationName = "jump";
        sa.AnimationState.SetAnimation(0, jumpName, false);
        sa.AnimationState.AddAnimation(0, "walk", true, 0);
        sa.skeleton.ScaleX = -1;
        sa.AnimationState.Start += (t) => 
        {
            //t包含一些动画的信息
            print(sa.AnimationName +  "动画开始播放");
        };
        sa.AnimationState.End += (t) => 
        {
            print(sa.AnimationName + "动画中断或清楚");
        };
        sa.AnimationState.Complete += (t) => {
            print(sa.AnimationName + "动画播放完成");
        };
        sa.AnimationState.Event += (t, e) =>
        {
            print(sa.AnimationName + "自定义事件");
        };
        Bone b = sa.skeleton.FindBone(boneName);
        //sa.skeleton.SetAttachment(slotName, attachmentName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
