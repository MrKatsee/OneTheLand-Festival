using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_IrisSkill2BF : MonoBehaviour {
    
    public float targetUnitLength;
    public Vector2 targetUnit_Skill;
    int isPlayer_IrisSkill;
    GameObject L_P1_IrisSkill;
    GameObject L_P2_IrisSkill;

    Vector2 bulletP_IrisSkill;
    Vector2 oppP_IrisSkill;
    Vector2 targeting_IrisSkill;

    public GameObject irisSkillBombBullet;

    // Use this for initialization
    void Start () {
        isPlayer_IrisSkill = gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet;
        L_P1_IrisSkill = GameObject.Find("L_P1Start");
        L_P2_IrisSkill = GameObject.Find("L_P2Start");
    }

    // Update is called once per frame
    void Update () {
        bulletP_IrisSkill = gameObject.transform.position;

        if (isPlayer_IrisSkill == 1)
        {
            oppP_IrisSkill = L_P2_IrisSkill.gameObject.GetComponent<BattleStart>().p2P;
        }

        if (isPlayer_IrisSkill == 2)
        {
            oppP_IrisSkill = L_P1_IrisSkill.gameObject.GetComponent<BattleStart>().p1P;
        }

        targeting_IrisSkill = oppP_IrisSkill - bulletP_IrisSkill;
        targeting_IrisSkill.Normalize();

        GetComponent<Rigidbody2D>().velocity = targeting_IrisSkill * 200;
    }

    public void IrisSkill2_Bomb()
    {
        GameObject[] irisBombBullet = new GameObject[12];

        for(int i = 0; i < 12; i++)
        {
            float irisBombBulletRotation;
            irisBombBulletRotation = i / 12f;
            irisBombBullet[i] = Instantiate(irisSkillBombBullet, gameObject.transform.position, Quaternion.Euler(0, 0, irisBombBulletRotation));
            irisBombBullet[i].GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_IrisSkill;
            irisBombBullet[i].GetComponent<Bullet_IrisSkill2BB>().IS2BB_Angle = irisBombBulletRotation;
            Destroy(irisBombBullet[i], 5f);
        }
    }
}
