using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigid = this.GetComponent<Rigidbody2D>();
        rigid.AddForce(new Vector2(0, 100));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
