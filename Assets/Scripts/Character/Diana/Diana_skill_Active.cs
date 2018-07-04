using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill_Active : MonoBehaviour {


	int isPlayer_C;
	int skillNum;

	GameObject L_P1;
	GameObject L_P2;
	// Use this for initialization
	void Start () {
		isPlayer_C = gameObject.GetComponent<InputKey>().isPlayer;
		L_P1 = GameObject.Find("L_P1Start");
		L_P2 = GameObject.Find("L_P2Start");
	}

	// Update is called once per frame
	void Update () {
		skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;
		if (skillNum == 1)
		{
			gameObject.GetComponent<Diana_passive>().skill1();
		}
		if(Input.GetKeyDown(KeyCode.A))
			Debug.Log(skillNum);
		gameObject.GetComponent<HPManagement>().skillTrigger = 0;
	}
}

