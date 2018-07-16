using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SL_MV_Map : MonoBehaviour {

	char[] SL={'m','a','p','1'};
	string select;
	public bool SL_Decide;
	GameObject UI_BG;
	GameObject UI_Ch;
	void Start () {
		Data.Map = 1;
		UI_Ch = Data.UI_Ch;
		UI_BG=Data.UI_BG;
	}

	void Update () {
		select = "";
		if (Input.GetKeyDown (KeyCode.A)) {
			if (SL [3] != '1') {
				SL [3]--;
				Data.Map--;
			}
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			if (SL [3] != '7') {
				SL [3]++;
				Data.Map++;
		
			}
		}
		foreach (char c in SL) 
		{
			select += c;
		}
		GetComponent<RectTransform> ().position = GameObject.Find (select).GetComponent<RectTransform> ().position;
		if (Input.GetKeyDown (KeyCode.T)) 
		{
			UI_Ch.gameObject.SetActive (true);

			select_p1.SL_Decide = false;
			select_p2.SL_Decide = false;
			UI_BG.gameObject.SetActive (false);
			SceneManager.LoadScene("GameScene");
		}
	}
}
