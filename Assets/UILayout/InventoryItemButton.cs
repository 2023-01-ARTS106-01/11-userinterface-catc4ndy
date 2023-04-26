using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{
    private Text buttonText;
    private string[] itemTypes = { "Armour", "Weapon", "Spell" };
    public int typeIndex;

    private void Awake()
    {
        typeIndex = Random.Range(0, 3);
        buttonText = GetComponentInChildren<Text>();
        buttonText.text = itemTypes [typeIndex];
    }
}
