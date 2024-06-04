using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class Lesson40 : MonoBehaviour
{
    public SpriteResolver sr;
    public Dictionary<string, SpriteResolver> equipDic = new Dictionary<string, SpriteResolver>();
    // Start is called before the first frame update
    void Start()
    {
        //sr.SetCategoryAndLabel(sr.GetCategory(), "CASK 1");
        SpriteResolver[] srs = this.GetComponentsInChildren<SpriteResolver>();
        for (int i = 0; i < srs.Length; i++)
        {
            equipDic.Add(srs[i].GetCategory(), srs[i]);
        }
        ChangeEquip("CASK", "CASK 1");
    }
    public void ChangeEquip(string categoryName, string equipName)
    {
        if (equipDic.ContainsKey(categoryName))
        {
            equipDic[categoryName].SetCategoryAndLabel(categoryName, equipName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
