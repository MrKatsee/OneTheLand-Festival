using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_IrisSkill4 : MonoBehaviour {
    GameObject isBullet_IrisSkill4;
    public GameObject Bullet_IrisSkill4;
    public int isPlayer_IrisSkill;

    Vector2 bulletP_IrisSkill;
    Vector2 oppP_IrisSkill;
    Vector2 targeting_IrisSkill;

    GameObject L_P1_IrisSkill;
    GameObject L_P2_IrisSkill;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1400f, 0f);
        isBullet_IrisSkill4 = GameObject.Find("BulletManager");
        StartCoroutine(TriggerEctasy());

        L_P1_IrisSkill = GameObject.Find("L_P1Start");
        L_P2_IrisSkill = GameObject.Find("L_P2Start");


    }

    // Update is called once per frame
    void Update () {

        if (isPlayer_IrisSkill == 1)
        {
            oppP_IrisSkill = L_P2_IrisSkill.gameObject.GetComponent<BattleStart>().p2P;
        }

        if (isPlayer_IrisSkill == 2)
        {
            oppP_IrisSkill = L_P1_IrisSkill.gameObject.GetComponent<BattleStart>().p1P;
        }

        Debug.Log(oppP_IrisSkill);

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        GameObject bulletEctasy;

        bulletP_IrisSkill = c.gameObject.transform.position;

        targeting_IrisSkill = oppP_IrisSkill - bulletP_IrisSkill;

        targeting_IrisSkill.Normalize();

        if (c.transform.parent == isBullet_IrisSkill4.transform)
        {
            float irisSkill4Angle = Vector2.Angle(targeting_IrisSkill, Vector2.right);
            irisSkill4Angle = targeting_IrisSkill.y > 0 ? irisSkill4Angle : -irisSkill4Angle;

            bulletEctasy = Instantiate(Bullet_IrisSkill4, c.transform.position + new Vector3(0f,0f,-1f), Quaternion.AngleAxis(irisSkill4Angle, Vector3.forward));
            bulletEctasy.transform.Rotate(targeting_IrisSkill);
            bulletEctasy.GetComponent<Bullet_Iris4B>().irisSkill4BVector = targeting_IrisSkill;
            bulletEctasy.GetComponent<BulletIdentifier>().isPlayer_Bullet = isPlayer_IrisSkill;

            Destroy(c.gameObject);
        }
    }

    IEnumerator TriggerEctasy()
    {
        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }
}
