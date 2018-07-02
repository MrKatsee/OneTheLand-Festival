using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_IrisSkill2BB : MonoBehaviour
{

    int speed_IrisSkill2BB;
    Vector2 IrisSkill2BB;
    public float IS2BB_Angle;

    // Use this for initialization
    void Start()
    {
        Vector2 test = Vector2.right;
        IS2BB_Angle *= 6.28f;
        test.x = Mathf.Cos(IS2BB_Angle);
        test.y = Mathf.Sin(IS2BB_Angle);
        speed_IrisSkill2BB = 200;
        GetComponent<Rigidbody2D>().velocity = speed_IrisSkill2BB * test;

        StartCoroutine(IrisSkill2BBEf());
        StartCoroutine(StopIrisSkill2BBEf());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IrisSkill2BBEf()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.02f);

        for (int i = 0; i < 100; i++)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, i * 0.01f);
            yield return new WaitForSeconds(0.01f);
        }

        for (int i = 100; i > 0; i--)
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
