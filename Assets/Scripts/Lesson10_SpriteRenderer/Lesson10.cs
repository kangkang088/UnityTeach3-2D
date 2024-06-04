using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer spriteRenderer = obj.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("dead1");
        Sprite[] sprites = Resources.LoadAll<Sprite>("RobotBoyIdleSprite");
        spriteRenderer.sprite = sprites[10];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
