using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private List<WeaponBox> weaponBoxes = new List<WeaponBox>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void gachaRoll()
    {
        WeaponBox wb = GameObject.Instantiate(WeaponBox);
    }
}