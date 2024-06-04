using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson31_Exericises : MonoBehaviour
{
    private Animation animation_s;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        animation_s = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isMoving = true;
            animation_s.CrossFade("Move");
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            isMoving = false;
            animation_s.CrossFade("Idle");
        }
        if (isMoving)
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        
    }
}
