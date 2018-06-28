using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_cNum1 : MonoBehaviour {

    public int skillNum;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;



        gameObject.GetComponent<HPManagement>().skillTrigger = 0;
    }
}
