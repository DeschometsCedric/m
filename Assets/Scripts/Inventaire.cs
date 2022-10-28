using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public InventaireUI inventaireUI;

    public List<Slot> slots = new List<Slot>(10);

    public void DeposerItem(Item itemADeposer,int nSlot = 0)
    {
        slots[nSlot].item = itemADeposer;
    }

    public Item PrendreItem(Item item)
    {
        //if (slots.Contains(item))
        {
            //slots.FindIndex
            //pour renitialliser l'item je fais new Item()
        }
        return item;
    }

    public void Start()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if(slots[i].ui != null) 
            { 

            if(slots[i].item.icon != null)
                slots[i].ui.icon.sprite = slots[i].item.icon;

            if (slots[i].quantite != 0)
                slots[i].ui.quantityText.text = slots[i].quantite.ToString();
            else
                slots[i].ui.quantityText.text = "";
            }
        }

    }
}
