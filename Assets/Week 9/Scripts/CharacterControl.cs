using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static TextMeshProUGUI villagerTypeText;

    public void Start()
    {
        villagerTypeText = FindObjectOfType<TextMeshProUGUI>();
    }

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
            villagerTypeText.text = "None";
        }
        SelectedVillager = villager;
        villagerTypeText.text = SelectedVillager.GetType().Name;
        SelectedVillager.Selected(true);
    }
    
}
