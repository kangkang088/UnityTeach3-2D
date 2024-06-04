using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer spriteRenderer = obj.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = MultipleMgr.Instance.GetSprite("RobotBoyIdleSprite", "RobotBoyIdle16");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
