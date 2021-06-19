using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Gacha()
    {
        var rand = new Random();

        int currentLevel = 0;
        int level;
        int i = 1;

        string[] weaponManufacturer =
            {"Atlas", "CoV", "Dahl", "Hyperion", "Jakobs", "Maliwan", "Tediore", "Torgue", "Vladof"};
        string[] weaponType = {"Handgun", "Shotgun", "Assault Rifle", "SMG", "Sniper", "Heavy Weapon"};
        string[] weaponRarity = {"Common", "Uncommon", "Rare", "Very Rare"};

        int manufacturerPick;
        int typePick;
        int rarityPick;

        Debug.Log("Current level : ");
        currentLevel = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < 9; i++)
        {
            manufacturerPick = rand.Next(8);
            typePick = rand.Next(5);
            rarityPick = rand.Next(3);
            level = rand.Next(currentLevel - 5, currentLevel + 5);

            Debug.Log("Level " + level + weaponRarity[rarityPick]+ weaponManufacturer[manufacturerPick] + weaponType[typePick]);
        }

        ;

    }
}
