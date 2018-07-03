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
		isPlayer_C = gameObject.GetComponent<InputKey>().isPlayer;
		L_P1 = GameObject.Find("L_P1Start");
		L_P2 = GameObject.Find("L_P2Start");
	}
	
	// Update is called once per frame
	void Update () {
		skillNum = gameObject.GetComponent<HPManagement>().skillTrigger;
		if (skillNum == 1)
		{
			Debug.Log("skill1");
			Diana_passive.Bullet_count = 1;
			gameObject.GetComponent<InputKey>().speed= 12;
			Invoke ("slow", 1f*Time.deltaTime);
		}
		gameObject.GetComponent<HPManagement>().skillTrigger = 0;
	}
	void slow()
	{
		gameObject.GetComponent<InputKey>().speed = 10;
	}
}
