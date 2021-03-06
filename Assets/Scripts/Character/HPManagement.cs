﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManagement : MonoBehaviour {

    public GameObject[] P1HP = new GameObject[5];
    public GameObject[] P2HP = new GameObject[5];
    public int HP;
    int HP_Max;
    int HP_temp;
    public float skillGuage;
    Image skillBar;
    Image skillBarUse;
    Image skillBarUsable;
    float skillGuageStack;
    public int isCharacter;
    public int skillTrigger;
    bool gamePuase_HP;
	public bool use=true;
    bool isSuper = false;

    // Use this for initialization
    void Start () {

        P1HP[0] = GameObject.Find("U_P1HP1");
        P1HP[1] = GameObject.Find("U_P1HP2");
        P1HP[2] = GameObject.Find("U_P1HP3");
        P1HP[3] = GameObject.Find("U_P1HP4");
        P1HP[4] = GameObject.Find("U_P1HP5");

        P2HP[0] = GameObject.Find("U_P2HP1");
        P2HP[1] = GameObject.Find("U_P2HP2");
        P2HP[2] = GameObject.Find("U_P2HP3");
        P2HP[3] = GameObject.Find("U_P2HP4");
        P2HP[4] = GameObject.Find("U_P2HP5");


        HP_temp = HP;
        HP_Max = HP;

        if (gameObject.GetComponent<InputKey>().isPlayer == 1)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i > HP_Max)
                {
                    P1HP[i-1].SetActive(false);
                }
            }
            skillBar = GameObject.Find("U_P1SkillGuage").GetComponent<Image>();
            skillBarUse = GameObject.Find("U_P1SkillGuageUse").GetComponent<Image>();
            skillBarUsable = GameObject.Find("U_P1SkillGuageUsable").GetComponent<Image>();
            isCharacter = GameObject.Find("L_P1Start").GetComponent<BattleStart>().cNum;
        }

        if (gameObject.GetComponent<InputKey>().isPlayer == 2)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i > HP_Max)
                {
                    P2HP[i - 1].SetActive(false);
                }
            }
            skillBar = GameObject.Find("U_P2SkillGuage").GetComponent<Image>();
            skillBarUse = GameObject.Find("U_P2SkillGuageUse").GetComponent<Image>();
            skillBarUsable = GameObject.Find("U_P2SkillGuageUsable").GetComponent<Image>();
            isCharacter = GameObject.Find("L_P2Start").GetComponent<BattleStart>().cNum;
        }

        skillGuage = 0;
        skillGuageStack = 0;
    }
	void Update () {
        gamePuase_HP = GameManager.Instance.gamePause;

        if (HP != HP_temp)
        {
            AltHP();
        }

        AltSkillGuage();
        SkillUsableCheck();

        skillBarUse.fillAmount = skillGuageStack;
    }

    void AltHP()
    {
        if (HP > HP_Max)
        {
            HP -= 1;
        }

        if (gameObject.GetComponent<InputKey>().isPlayer == 1)
		{
			if (HP == 0) {
				GameOver.Gameover = true;
				GameOver.player = 2;
				P1HP[0].SetActive(false);
				P1HP[1].SetActive(false);
				P1HP[2].SetActive(false);
				P1HP[3].SetActive(false);
				P1HP[4].SetActive(false);
			}
            if (HP == 1)
            {

                P1HP[0].SetActive(true);
                P1HP[1].SetActive(false);
                P1HP[2].SetActive(false);
                P1HP[3].SetActive(false);
                P1HP[4].SetActive(false);
            }
            if (HP == 2)
            {

                P1HP[0].SetActive(true);
                P1HP[1].SetActive(true);
                P1HP[2].SetActive(false);
                P1HP[3].SetActive(false);
                P1HP[4].SetActive(false);
            }
            if (HP == 3)
            {

                P1HP[0].SetActive(true);
                P1HP[1].SetActive(true);
                P1HP[2].SetActive(true);
                P1HP[3].SetActive(false);
                P1HP[4].SetActive(false);
            }
            if (HP == 4)
            {

                P1HP[0].SetActive(true);
                P1HP[1].SetActive(true);
                P1HP[2].SetActive(true);
                P1HP[3].SetActive(true);
                P1HP[4].SetActive(false);
            }
            if (HP == 5)
            {

                P1HP[0].SetActive(true);
                P1HP[1].SetActive(true);
                P1HP[2].SetActive(true);
                P1HP[3].SetActive(true);
                P1HP[4].SetActive(true);
            }
            HP_temp = HP;

        }

        else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
		{
			if (HP == 0) {
				GameOver.Gameover = true;
				GameOver.player = 1;
				P2HP[0].SetActive(false);
				P2HP[1].SetActive(false);
				P2HP[2].SetActive(false);
				P2HP[3].SetActive(false);
				P2HP[4].SetActive(false);
			}
            if (HP == 1)
            {

                P2HP[0].SetActive(true);
                P2HP[1].SetActive(false);
                P2HP[2].SetActive(false);
                P2HP[3].SetActive(false);
                P2HP[4].SetActive(false);
            }
            if (HP == 2)
            {

                P2HP[0].SetActive(true);
                P2HP[1].SetActive(true);
                P2HP[2].SetActive(false);
                P2HP[3].SetActive(false);
                P2HP[4].SetActive(false);
            }
            if (HP == 3)
            {

                P2HP[0].SetActive(true);
                P2HP[1].SetActive(true);
                P2HP[2].SetActive(true);
                P2HP[3].SetActive(false);
                P2HP[4].SetActive(false);
            }
            if (HP == 4)
            {

                P2HP[0].SetActive(true);
                P2HP[1].SetActive(true);
                P2HP[2].SetActive(true);
                P2HP[3].SetActive(true);
                P2HP[4].SetActive(false);
            }
            if (HP == 5)
            {

                P2HP[0].SetActive(true);
                P2HP[1].SetActive(true);
                P2HP[2].SetActive(true);
                P2HP[3].SetActive(true);
                P2HP[4].SetActive(true);
            }
            HP_temp = HP;

        }

    }

    void AltSkillGuage()
    {
        if (skillGuage <= 1f && gamePuase_HP == false)
        {
            skillGuage += 0.1f * Time.deltaTime;
        }

        skillBar.fillAmount = skillGuage;
    }

    public void AltSkillGuageUse()
    {
        if (skillGuageStack <= 1f && skillGuageStack <= skillGuage)
        {
            skillGuageStack += 0.5f * Time.deltaTime;
        }
    }

    public void SkillUseTrigger()
    {
        //skill trigger by character
        if (isCharacter == 1)
        {
            if (skillGuageStack >= 0.25f)
            {
				skillTrigger = 1;
				skillGuage -= 0.25f;
            }
            if (skillGuageStack >= 0.5f)
            {
				skillTrigger = 2;
				skillGuage -= 0.5f;
            }
            if (skillGuageStack >= 0.75f)
            {
				skillTrigger = 3;
				skillGuage -= 0.75f;
            }
            if (skillGuageStack >= 1f)
            {
				skillTrigger = 4;
				skillGuage -= 0.99f;
            }
            skillGuageStack = 0f;
        }

        if (isCharacter == 2)
        {
			if (use==true&&skillGuageStack >= 0.1f)
			{
				skillTrigger = 1;
				skillGuage -= 0.1f;
            }
            if (skillGuageStack >= 0.3f)
            {
				skillTrigger = 2;
				skillGuage -= 0.3f;
            }
            if (skillGuageStack >= 0.5f)
            {
				skillTrigger = 3;
				skillGuage -= 0.5f;
            }
            if (skillGuageStack >= 1f)
            {
				skillTrigger = 4;
				skillGuage -= 0.99f;
            }
            skillGuageStack = 0f;
        }
    }

    public void SkillUsableCheck()
    {
        
        if (isCharacter == 1)
        {
            if (skillGuageStack >= 0f)
            {
                skillBarUsable.fillAmount = 0f;
            }
            if (skillGuageStack >= 0.25f)
            {
                skillBarUsable.fillAmount = 0.25f;
            }
            if (skillGuageStack >= 0.5f)
            {
                skillBarUsable.fillAmount = 0.5f;
            }
            if (skillGuageStack >= 0.75f)
            {
                skillBarUsable.fillAmount = 0.75f;
            }
            if (skillGuageStack >= 1f)
            {
                skillBarUsable.fillAmount = 1f;
            }
        }

        if (isCharacter == 2)
        {
            if (skillGuageStack >= 0f)
            {
                skillBarUsable.fillAmount = 0f;
            }
			if (use==true&&skillGuageStack >= 0.1f)
            {
                skillBarUsable.fillAmount = 0.1f;
            }
            if (skillGuageStack >= 0.3f)
            {
                skillBarUsable.fillAmount = 0.3f;
            }
            if (skillGuageStack >= 0.5f)
            {
                skillBarUsable.fillAmount = 0.5f;
            }
            if (skillGuageStack >= 1f)
            {
                skillBarUsable.fillAmount = 1f;
            }
        }
    }
    public void SkillGuageCancle()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {

        if (c.tag == "Bullet" && isSuper == false)
        {
            if (gameObject.GetComponent<InputKey>().isPlayer != c.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet)
            {
                if (c.GetComponent<BulletIdentifier>().isBullet == 1)
                {
                    c.GetComponent<Bullet_IrisSkill2BF>().StopBF_Fly();
                }
                if (c.gameObject.GetComponent<BulletIdentifier>().isDestroiable == true)
                {
                    Destroy(c.gameObject);
                }

                StartCoroutine(Super());
                HP -= 1;
            }
        }
    }

    IEnumerator Super()
    {
        isSuper = true;
        for (int i = 0; i < 5; i++)
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(0.1f);
        }
        isSuper = false;
    }

}
