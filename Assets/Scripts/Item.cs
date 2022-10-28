using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string displayName;
    public string description;
    public bool isEquipement;
    public Sprite icon;
    public SlotType type = SlotType.NONE;
}

