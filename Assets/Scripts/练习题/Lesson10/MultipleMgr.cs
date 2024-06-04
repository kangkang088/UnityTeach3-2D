using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleMgr : MonoBehaviour
{
    private static MultipleMgr instance = new MultipleMgr();
    public static MultipleMgr Instance => instance;
    //存储大图对应的小图资源信息
    private Dictionary<string, Dictionary<string, Sprite>> dic = new Dictionary<string, Dictionary<string, Sprite>>();
    private MultipleMgr()
    {

    }
    /// <summary>
    /// 获取图集中的某一张小图
    /// </summary>
    /// <param name="multipleName">图集名字</param>
    /// <param name="spriteName">图片名字</param>
    /// <returns></returns>
    public Sprite GetSprite(string multipleName, string spriteName)
    {
        if (dic.ContainsKey(multipleName))
        {
            if (dic[multipleName].ContainsKey(spriteName))
                return dic[multipleName][spriteName];
        }
        else
        {
            Dictionary<string, Sprite> dicTmp = new Dictionary<string, Sprite>();
            Sprite[] sprites = Resources.LoadAll<Sprite>(multipleName);
            for (int i = 0; i < sprites.Length; i++)
            {
                dicTmp.Add(sprites[i].name, sprites[i]);
            }
            dic.Add(multipleName, dicTmp);
            if (dicTmp.ContainsKey(spriteName))
                return dicTmp[spriteName];
        }
        return null;
    }
    public void CleanInfo()
    {
        dic.Clear();
        Resources.UnloadUnusedAssets();
    }
}
