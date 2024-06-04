using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson64 : MonoBehaviour
{
    private CharacterController cc;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        cc = this.GetComponent<CharacterController>();
        animator = this.GetComponent<Animator>();
        if (cc.isGrounded)
        {
            print("接触地面了");
        }
        cc.SimpleMove(Vector3.forward * 10 * Time.deltaTime);
        cc.Move(Vector3.forward * 10 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Speed", (int)Input.GetAxisRaw("Vertical"));
        cc.Move(this.transform.forward * 10 * Time.deltaTime * Input.GetAxisRaw("Vertical"));
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("碰到的对象名字：" + hit.gameObject.name);
    }
}
