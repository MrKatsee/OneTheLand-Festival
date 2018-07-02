using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_IrisSkill2Ef : MonoBehaviour {

    public int speed_IrisSkill2BBEf;
    Vector2 IrisSkill2BB;
    public float IS2BBEf_Angle;

    // Use this for initialization
    void Start()
    {
        Vector2 test = Vector2.right;
        IS2BBEf_Angle *= 6.28f;
        IS2BBEf_Angle -= 0.27f;

        test.x = Mathf.Cos(IS2BBEf_Angle);
        test.y = Mathf.Sin(IS2BBEf_Angle);
        GetComponent<Rigidbody2D>().velocity = speed_IrisSkill2BBEf * test;

        StartCoroutine(IrisSkill2BBEf());
        StartCoroutine(StopIrisSkill2BBEf());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator IrisSkill2BBEf()
    {
        for (int i = 100; i > 0; i -= 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, i * 0.01f);
            yield return new WaitForSeconds(0.01f);
        }

    }
    IEnumerator StopIrisSkill2BBEf()
    {
        yield return new WaitForSeconds(4.9f);

        StopCoroutine(IrisSkill2BBEf());
        StopCoroutine(StopIrisSkill2BBEf());
    }

}
