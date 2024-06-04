using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson31 : MonoBehaviour
{
    private Animation animation_s;
    // Start is called before the first frame update
    void Start()
    {
        animation_s = this.GetComponent<Animation>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animation_s.Play("1");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animation_s.Play("2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animation_s.CrossFade("3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //animation_s.PlayQueued("2");
            animation_s.CrossFadeQueued("2");
        }
    }
}
