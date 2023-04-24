using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    public void ShowOnly(int itemType)
    {
        for (int i = 0; i < transform.childcount; i++)
        {
            InventoryItemButton thisItem = transform.GetChild(i).GetComponent<InventoryItemButton>();
            thisItem.gameObject.SetActive(thisItem.typeIndex == itemType);
        }
    }

    public void ShowAll()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
