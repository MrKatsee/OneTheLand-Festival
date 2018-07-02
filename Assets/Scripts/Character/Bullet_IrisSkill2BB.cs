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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
