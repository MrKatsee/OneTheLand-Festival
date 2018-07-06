using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch_Name_1 : MonoBehaviour {

	string[] Ch_name= new string[7];
	void Start () {
		Ch_name [0] = "아이리스";
		Ch_name [1] = "다이아나";
		Ch_name [2] = "아이리스";
		Ch_name [3] = "다이아나";
		Ch_name [4] = "아이리스";
		Ch_name [5] = "다이아나";
		Ch_name [6] = "아이리스";
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text=Ch_name[Data.P1-1];
		
	}
}
