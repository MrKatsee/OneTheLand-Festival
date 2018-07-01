using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_cNum2 : MonoBehaviour
{

    int skillNum;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;

        if (skillNum == 1)
        {
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
}
