using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_p2 : MonoBehaviour {

	int P2;
	char[] SL2={'C','h','7'};
	string select;
	public GameObject SL_Ch;
	public static bool SL_Decide=false;
	void Start () {
		P2 = 1;

		////캐릭터 선택 Data 테스트////
		Data.left_player = 100;
	}

	void Update () {
		select = "";
		if (Input.GetKeyDown (KeyCode.LeftArrow)&&SL_Decide==false) {
			if (SL2[2] != '1') {
				SL2[2]--;
				P2--;
			}
		} else if (Input.GetKeyDown (KeyCode.RightArrow)&&SL_Decide==false) {
			if (SL2 [2] != '7') {
				SL2[2]++;
				P2++;
			}
		}
		foreach(char c in SL2)
		{
			select +=c;
		}
		SL_Ch.GetComponent<RectTransform> ().position = GameObject.Find (select).GetComponent<RectTransform> ().position;
		if (Input.GetKeyDown (KeyCode.Slash)) 
		{
			SL_Decide = true;
		}
		else if(Input.GetKeyDown(KeyCode.Period))
		{
			SL_Decide = false;
			Debug.Log ("HelloWorld");
		}
	}
}
