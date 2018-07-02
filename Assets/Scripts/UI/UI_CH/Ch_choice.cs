using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_choice : MonoBehaviour {
	private GameObject UIBG;
	void Start()
	{
		UIBG = Data.UI_BG;
	}
	void Update () {
		//0이 되 둘 중 하가 false면 true가 됨
		if(select_p1.SL_Decide==true&&select_p2.SL_Decide==true)
		{
			//Ch_Time.timerstart = false;
			gameObject.SetActive (false);
			UIBG.SetActive (true);
		}
	}
}
