using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_p1 : MonoBehaviour {

	int P1;
	char[] SL1={'C','h','1'};
	static string select;
	public GameObject SL_Ch;
	public static bool SL_Decide=false;
	// Use this for initialization
	void Start () {
		P1 = 1;
	}
	
	// Update is called once per frame
	void Update () {
		select = "";
		if (Input.GetKeyDown (KeyCode.A)&&SL_Decide==false) {
			if (SL1[2] != '1') {
				SL1[2]--;
				P1--;
			}
		} else if (Input.GetKeyDown (KeyCode.D)&&SL_Decide==false) {
			if (SL1[2] != '7') {
				SL1[2]++;
				P1++;
			}
		}
		foreach(char c in SL1)
		{
			select +=c;
		}
		SL_Ch.GetComponent<RectTransform> ().position = GameObject.Find (select).GetComponent<RectTransform> ().position;
		if (Input.GetKeyDown (KeyCode.T)) 
		{
			SL_Decide = true;
		}
		else if(Input.GetKeyDown(KeyCode.Y))
		{
			SL_Decide = false;
		}
	}
}
