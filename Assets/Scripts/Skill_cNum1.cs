﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_cNum1 : MonoBehaviour {

    int skillNum;
    public Vector2 myP;
    public Vector2 oppP;
    public Vector2 target;
    int isPlayer_C;

    GameObject L_P1;
    GameObject L_P2;

    public GameObject irisSkill1_AttackJud;
    public GameObject irisSkill1_AttackVisual;


    // Use this for initialization
    void Start () {
        isPlayer_C = gameObject.GetComponent<InputKey>().isPlayer;
        L_P1 = GameObject.Find("L_P1Start");
        L_P2 = GameObject.Find("L_P2Start");

    }

    // Update is called once per frame
    void Update () {
        myP = gameObject.transform.position;

        if (isPlayer_C == 1)
        {
            L_P1.gameObject.GetComponent<BattleStart>().p1P = myP;
            oppP = L_P2.gameObject.GetComponent<BattleStart>().p2P;
        }

        if (isPlayer_C == 2)
        {
            L_P2.gameObject.GetComponent<BattleStart>().p2P = myP;
            oppP = L_P1.gameObject.GetComponent<BattleStart>().p1P;
        }
		target = oppP - myP;//나의 위치와 상대방 위치를 계산 (실시간)

        Debug.Log("myP: " + myP);
        Debug.Log("oppP: " + oppP);

        skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;

        if (skillNum == 1)
        {
            Iris_Skill1();
            Debug.Log("skill1");

        }
        if (skillNum == 2)
        {
            Debug.Log("skill2");
        }
        if (skillNum == 3)
        {
            Debug.Log("skill3");
        }
        if (skillNum == 4)
        {
            Debug.Log("skill4");
        }

        gameObject.GetComponent<HPManagement>().skillTrigger = 0;
    }

    void Iris_Skill1()
    {
        float angle = Vector2.Angle(target, transform.right);
        GameObject temp1;
        temp1 = Instantiate(irisSkill1_AttackJud, transform.position, Quaternion.Euler(0, 0, angle));
        Instantiate(irisSkill1_AttackVisual, transform.position, Quaternion.Euler(0, 0, angle));
        temp1.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_C;
    }
}

