using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_choice : MonoBehaviour {
	GameObject i;
	void Start () {
		i = GameObject.Find("P2_Ch");
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			////캐릭터 선택창 선택Data 유지 테스트////
			Destroy (i);
			Debug.Log (Data.left_player);
			Data.right_player = 200;
			Debug.Log (Data.right_player);
		}
		if(select_p1.SL_Decide==true&&select_p2.SL_Decide==true)
		{

		}
	}
}
