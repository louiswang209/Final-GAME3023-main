using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Attribute which allows right click->Create
[CreateAssetMenu(fileName = "New Skill", menuName = "Skills/New Skill")]

public class Skills : ScriptableObject //Extending SO allows us to have an object which exists in the project, not in the scene
{
    public string description = "";

    //create the enum for item effect, so programmers can edit that within Unity when they create a new item or modifiy the existing item.
    public enum itemEffect { NONE, LVL, HP, MAXHP, MANA, MAXMANA, STR, DEF, INT, DEX, SPD };

    //there are maximum of three effect one item can have at the same time
    //programmer pick which stat the item will be effecting, and how that stat will be effected(+10, -5, +1< etc...)
    public itemEffect itemEffect1;
    public int itemEffectData1 = 0;

    public bool isConsumable = false;
}
