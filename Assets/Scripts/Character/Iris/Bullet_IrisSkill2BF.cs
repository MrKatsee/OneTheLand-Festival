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
    public GameObject irisSkillBombBulletEf;

    public GameObject irisSkill2_BF1;
    public GameObject irisSkill2_BF2;
    public GameObject irisRef;

    public GameObject irisSkill2EffectLocation;
    GameObject irisSkill2EffectL;

    GameObject tempObject;
    public int isFly = 0;
    int isFlyEf = 0;
    public int isPlayIrisSkill2;
    float stack;

    // Use this for initialization
    void Start () {
        isPlayer_IrisSkill = gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet;
        L_P1_IrisSkill = GameObject.Find("L_P1Start");
        L_P2_IrisSkill = GameObject.Find("L_P2Start");


        StartCoroutine(BF_Fly());
        StartCoroutine(BF_FlyEf());

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

        if (isFly == 1)
        {
            tempObject.transform.position = gameObject.transform.position;
        }
        if (isFlyEf == 1)
        {
            irisSkill2EffectL.transform.position = gameObject.transform.position;
        }


    }

    public void StopBF_Fly()
    {
        if (isFly == 1)
        {
            Destroy(tempObject);
            isFly = 0;
        }
        if (isPlayIrisSkill2 == 1)
            irisRef.GetComponent<Skill_cNum1>().isPlayIrisBF = 2;

        if (isPlayIrisSkill2 == 2)
            irisRef.GetComponent<Skill_cNum1>().isPlayIrisBF2 = 2;
        StopCoroutine(BF_Fly());
    }

    IEnumerator BF_Fly()
    {

        while (true)
        {
            isFly = 1;

            tempObject = Instantiate(irisSkill2_BF1, gameObject.transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.25f);

            isFly = 0;
            Destroy(tempObject);
            isFly = 1;

            tempObject = Instantiate(irisSkill2_BF2, gameObject.transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.25f);

            stack += 0.5f;

            isFly = 0;
            Destroy(tempObject);
        }
    }

    IEnumerator BF_FlyEf()
    {
        irisSkill2EffectL = Instantiate(irisSkill2EffectLocation, transform.position, Quaternion.identity);
        isFlyEf = 1;
        irisSkill2EffectL.GetComponent<Bullet_IrisSkill2Ef2>().isIrisSkill2Ef2 = 1;

        yield return new WaitForSeconds(4.5f);

        isFlyEf = 0;
        irisSkill2EffectL.GetComponent<Bullet_IrisSkill2Ef2>().isIrisSkill2Ef2 = 0;
        Destroy(irisSkill2EffectL);
    }


    public void IrisSkill2_Bomb()
    {
        GameObject[] irisBombBullet = new GameObject[12];
        GameObject[] irisBombBulletEf = new GameObject[12];

        for (int i = 0; i < 12; i++)
        {
            float irisBombBulletRotation;
            irisBombBulletRotation = i / 12f;
            irisBombBullet[i] = Instantiate(irisSkillBombBullet, gameObject.transform.position, Quaternion.Euler(0, 0, irisBombBulletRotation));
            irisBombBullet[i].GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_IrisSkill;
            irisBombBullet[i].GetComponent<Bullet_IrisSkill2BB>().IS2BB_Angle = irisBombBulletRotation;
            irisBombBullet[i].transform.parent = GameObject.Find("BulletManager").transform;
            Destroy(irisBombBullet[i], 5f);
        }
        for (int i = 0; i < 12; i++)
        {
            float irisBombBulletRotation;
            irisBombBulletRotation = i / 12f;
            irisBombBulletEf[i] = Instantiate(irisSkillBombBulletEf, gameObject.transform.position, Quaternion.Euler(0, 0, irisBombBulletRotation));
            irisBombBulletEf[i].GetComponent<Bullet_IrisSkill2Ef>().IS2BBEf_Angle = irisBombBulletRotation;
            Destroy(irisBombBulletEf[i], 3f);
        }
    }
}
