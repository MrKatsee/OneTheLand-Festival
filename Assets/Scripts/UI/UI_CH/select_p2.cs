using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class select_p2 : MonoBehaviour {

	char[] SL2={'C','h','7'};
	string select;
	public GameObject SL_Ch;
	public static bool SL_Decide;
	void Start () {
		Data.P2 = 7;
		SL_Decide = false;
		SL_Ch.GetComponent<Image>().color= new Color(0,0,10,1);
	}

	void Update () {
		select = "";
		if (Input.GetKeyDown (KeyCode.LeftArrow)&&SL_Decide==false) {
			if (SL2[2] != '1') {
				SL2[2]--;
				Data.P2--;
			}
		} else if (Input.GetKeyDown (KeyCode.RightArrow)&&SL_Decide==false) {
			if (SL2 [2] != '7') {
				SL2[2]++;
				Data.P2++;
			}
		}
		foreach(char c in SL2)
		{
			select +=c;
		}
		SL_Ch.GetComponent<RectTransform> ().position = GameObject.Find (select).GetComponent<RectTransform> ().position;
		if (Input.GetKeyDown (KeyCode.Period)) 
		{
			SL_Decide = true;
			SL_Ch.GetComponent<Image>().color= new Color(10,10,10,1);
		}
		else if(Input.GetKeyDown(KeyCode.Slash))
		{
			SL_Decide = false;
			SL_Ch.GetComponent<Image>().color= new Color(0,0,10,1);
		}
	}
}
