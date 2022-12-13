using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerBattleAct : MonoBehaviour
{
    [SerializeField]
    Image playerIcon;
    public Skills skill1 = null;
    public Skills skill2 = null;
    public Skills skill3 = null;
    public Skills skill4 = null;


    public Slider healthBar;

    public int Health = 0;
    public int Attack = 0;
    public int Defence = 0;
    public int Speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = Health;
        healthBar.value = Health;
        healthBar.Rebuild(CanvasUpdate.MaxUpdateValue);
    }

    // Update is called once per frame
    void Update()
    {
        Health -= 1;
        healthBar.value = Health;
    }

    void Punch()
    {

    }
}
