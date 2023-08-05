using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemScriptableObject : ScriptableObject
{
    public string[] ids ;
    public Sprite[] sprites; 

    public int GetIndex(string id){
        for(int i =0;i<ids.Length;i++)
        {
            if(ids[i] == id) return i;
        }

        return 0;
    }
}
