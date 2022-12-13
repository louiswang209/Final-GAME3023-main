using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnemyBattleAct : MonoBehaviour
{

    public Enemy enemy = null;


    [SerializeField]
    Image enemyIcon;

    [SerializeField]
    private TMPro.TextMeshProUGUI enemyName;

    public Skills skill1 = null;
    public Skills skill2 = null;
    public Skills skill3 = null;
    public Skills skill4 = null;

    public int tempHealth = 0;

    [SerializeField]
    public Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        skill1 = enemy.skill1;
        skill2 = enemy.skill2;
        skill3 = enemy.skill3;
        skill4 = enemy.skill4;
        enemyName.text = enemy.name;

        tempHealth = enemy.Health;
        healthBar.maxValue = tempHealth;
        healthBar.value = tempHealth;
        healthBar.Rebuild(CanvasUpdate.MaxUpdateValue);
    }

    // Update is called once per frame
    void Update()
    {
        enemyIcon.sprite = enemy.icon;
        enemyIcon.gameObject.SetActive(true);


        tempHealth -= 1;
        healthBar.value = tempHealth;
    }
}
