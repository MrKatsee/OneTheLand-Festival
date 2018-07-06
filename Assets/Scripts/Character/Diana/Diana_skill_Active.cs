using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill_Active : MonoBehaviour {


	int isPlayer_C;
	int skillNum;
	GameObject wing;
	GameObject L_P1;
	GameObject L_P2;
	public GameObject DianaSkillCutIn;
	public bool skill4_end = false;
	// Use this for initialization
	void Start () {
		wing = GameObject.Find ("Wing");
		wing.SetActive (false);
		isPlayer_C = gameObject.GetComponent<InputKey>().isPlayer;
		L_P1 = GameObject.Find("L_P1Start");
		L_P2 = GameObject.Find("L_P2Start");
	}

	// Update is called once per frame
	void Update () {
		skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;
		if (GetComponent<HPManagement>().use==true&&skillNum == 1)
		{
			gameObject.GetComponent<Diana_passive>().skill1();
		}
		if (skillNum == 2)
		{
			gameObject.GetComponent<Diana_skill_2>().skill2();
		}
		if (skillNum == 3)
		{
			gameObject.GetComponent<Diana_skill3>().skill3();
		}
		if (skillNum == 4)
		{
			wing.SetActive (true);
			gameObject.GetComponent<Diana_skill4>().skill4();
		}
		if (skill4_end == true) {
			wing.SetActive (false);
			skill4_end = false;
		}
		gameObject.GetComponent<HPManagement>().skillTrigger = 0;
	}
}

