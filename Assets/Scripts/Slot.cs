using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Slot 
{
    public string displayName = "Slot";
    public SlotType type = SlotType.NONE;
    public Item item;
    public int quantite = 0;
    public int quantiteMax = 42;
    public SlotUI ui;
}

public enum SlotType
{
    HELMET, 
    CHEST, 
    SHOULDERS, 
    GLOVES, 
    BELT, 
    GREAVES, 
    BOOTS,
    RIGHT_HAND, 
    LEFT_HAND,
    NONE
}

