using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static TextMeshProUGUI villagerTypeText;
    public Canvas canvas;

    public List<Villager> villagers;

    public void Start()
    {
       // villagerTypeText = FindFirstObjectByType<TextMeshProUGUI>();
       villagerTypeText = canvas.GetComponentInChildren<TextMeshProUGUI>();
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

    public void ChangeVillagerSelection(int villagerNumber)
    {
        SetSelectedVillager(villagers[villagerNumber]);
    }

    public void ChangeVillagerScale(float scale)
    {
        SelectedVillager.gameObject.transform.localScale = new Vector3 (scale, scale, scale);
    }
    
}
