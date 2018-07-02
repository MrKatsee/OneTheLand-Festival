using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_cNum1 : MonoBehaviour {

    int skillNum;
    public Vector2 myP;
    public Vector2 oppP;
    public Vector2 target;
    int isPlayer_C;
    float targetLength;
    Vector2 targetUnit;

    GameObject L_P1;
    GameObject L_P2;

    public GameObject irisSkill1_AttackJud;
    public GameObject irisSkill1_AttackVisual1;
    public GameObject irisSkill1_AttackVisual2;
    public GameObject irisSkill1_AttackVisual3;
    public GameObject irisSkill1_AttackPreView1;
    public GameObject irisSkill2_Butterfly;

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
        target = oppP - myP;
        

        skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;

        if (skillNum == 1)
        {
            StartCoroutine(Iris_Skill1());
            Debug.Log("skill1");
        }
        if (skillNum == 2)
        {
            StartCoroutine(Iris_Skill2());
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

    IEnumerator Iris_Skill1()
    {
        float targetingAngle = Vector2.Angle(target, transform.right);
        targetingAngle = target.y > 0 ? targetingAngle : -targetingAngle;

        GameObject guideLine;
        GameObject graphicObject1;
        GameObject graphicObject2;
        GameObject graphicObject3;
        GameObject colliderObject;

        guideLine = Instantiate(irisSkill1_AttackPreView1, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.Euler(0, 0, targetingAngle));
        Destroy(guideLine, 0.45f);
        gameObject.GetComponent<InputKey>().canMove = 0;

        yield return new WaitForSeconds(0.4f);

        guideLine.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);

        yield return new WaitForSeconds(0.2f);

        graphicObject1 = Instantiate(irisSkill1_AttackVisual1, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.Euler(0, 0, targetingAngle));
        Destroy(graphicObject1, 0.1f);
        colliderObject = Instantiate(irisSkill1_AttackJud, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.Euler(0, 0, targetingAngle));
        colliderObject.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_C;
        Destroy(colliderObject, 0.2f);
        graphicObject2 = Instantiate(irisSkill1_AttackVisual2, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.Euler(0, 0, targetingAngle));
        Destroy(graphicObject2, 0.15f);
        graphicObject3 = Instantiate(irisSkill1_AttackVisual3, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.Euler(0, 0, targetingAngle));
        Destroy(graphicObject3, 0.2f);

        gameObject.GetComponent<InputKey>().canMove = 1;
    }

    IEnumerator Iris_Skill2()
    {
        GameObject butterfly;

        targetLength = Vector2.Distance(oppP, myP);

        butterfly = Instantiate(irisSkill2_Butterfly, transform.position + gameObject.GetComponent<NormalAttack>().bulletShootPosition, Quaternion.identity);
        butterfly.gameObject.GetComponent<Bullet_IrisSkill2BF>().targetUnit_Skill = target;
        butterfly.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_C;

        yield return new WaitForSeconds(5f);

        butterfly.gameObject.GetComponent<Bullet_IrisSkill2BF>().IrisSkill2_Bomb();
        Destroy(butterfly);
    }
}

