using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="ITEM",menuName = "new Item")]
public class Item : ScriptableObject
{
    public int number;
    public string itemName;
    public Sprite image;

}
