using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
    private static int currentLevel = 1;

    static Dictionary<int, string> manufacturer = new Dictionary<int, string>()
    {
        {0, "Atlas"}, {1, "CoV"}, {2, "Dahl"}, {3, "Hyperion"}, {4, "Jakobs"}, {5, "Maliwan"}, {6, "Tediore"}, {7, "Torgue"}, {8, "Vladof"}
    };
    static Dictionary<int, string> type = new Dictionary<int, string>()
    {
        {0, "Handgun"}, {1, "Shotgun"}, {2, "Assault Rifle"}, {3, "SMG"}, {4, "Sniper"}, {5, "Heavy Weapon"}
    };
    static Dictionary<int, string> rarity = new Dictionary<int, string>()
    {
        {0, "Common"}, {1, "Uncommon"}, {2, "Rare"}, {3, "Very Rare"}
    };

    private static Dictionary<int, Weapon> weaponsList = new Dictionary<int, Weapon>();
        
        
    class Weapon
    {
        private string weaponManufacturer;
        private string weaponType;
        private string weaponRarity;
        private int weaponLevel;

        public Weapon()
        {
            weaponManufacturer = manufacturer[Random.Range(0, 8)];
            weaponType = type[Random.Range(0, 5)];
            weaponRarity = rarity[Random.Range(0, 3)];
            weaponLevel = Random.Range(currentLevel - 5, currentLevel + 5);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void tenRoll()
    {
        for (int i = 0; i < 10; i++)
            weaponsList.Add(i, new Weapon());
    }
}
