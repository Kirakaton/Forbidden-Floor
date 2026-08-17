using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public int maxSlots = 4;

    private List<string> items = new List<string>();

    public bool AddItem(string itemName)
    {
        if (items.Count >= maxSlots)
        {
            Debug.Log("Инвентарь заполнен");
            return false;
        }

        items.Add(itemName);
        Debug.Log(itemName + " добавлен");
        return true;
    }

    public void RemoveItem(string itemName)
    {
        items.Remove(itemName);
    }
}