﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lesson14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = new GameObject();
        SpriteRenderer sr = obj.AddComponent<SpriteRenderer>();
        SpriteAtlas atlas = Resources.Load<SpriteAtlas>("My Atlas");
        sr.sprite = atlas.GetSprite("dead1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
