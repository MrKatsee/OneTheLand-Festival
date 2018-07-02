using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill_1 : MonoBehaviour {

	int isPlayer_C;
	int skillNum;

	GameObject L_P1;
	GameObject L_P2;
	// Use this for initialization
	void Start () {
		isPlayer_C = gameObject.GetComponent<Diana_Moving>().isPlayer;
		L_P1 = GameObject.Find("L_P1Start");
		L_P2 = GameObject.Find("L_P2Start");
		skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;
	}
	
	// Update is called once per frame
	void Update () {
		if (skillNum == 1)
		{
			Diana_passive.Bullet_count = 1;
			InputKey.speed= 12;
			Invoke ("slow", 1f*Time.deltaTime);
		}
	}
	void slow()
	{
		InputKey.speed = 10;
	}
}
