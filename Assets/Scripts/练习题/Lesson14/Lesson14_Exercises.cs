using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson14_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        SpriteAtlas altas = Resources.Load<SpriteAtlas>("Pig Atlas");
        sr.sprite = altas.GetSprite("dead1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
