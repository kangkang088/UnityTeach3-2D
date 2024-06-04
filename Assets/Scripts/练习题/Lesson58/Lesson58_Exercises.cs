using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson58_Exercises : MonoBehaviour
{
    private Animator animator;
    public Transform headPos;
    private float changeAngleX;
    private CharacterController cc;
    public float speed = 10.0f;
    public float roundSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        cc = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("X", Input.GetAxis("Horizontal"));
        animator.SetFloat("Y", Input.GetAxis("Vertical"));
        if (Input.GetKeyDown(KeyCode.K))
            animator.SetTrigger("Fire");
        changeAngleX += Input.GetAxis("Mouse X");
        changeAngleX = Mathf.Clamp(changeAngleX, -30, 30);
        cc.SimpleMove(this.transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
        this.transform.Rotate(Vector3.up, roundSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(1,1,1);
        Vector3 pos = Quaternion.AngleAxis(changeAngleX, Vector3.up) * (headPos.position + headPos.forward * 10);
        animator.SetLookAtPosition(pos);
    }
}
