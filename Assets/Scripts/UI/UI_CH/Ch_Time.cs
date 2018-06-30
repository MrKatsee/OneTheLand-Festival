using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch_Time : MonoBehaviour {
	Sprite[] number = new Sprite[10];
	List<char> imagenum = new List<char> { 'n', 'u', 'm', 'b', 'e', 'r','0' };
	string number_image ;
	int time_one, time_ten;
	public static bool timerstart ;
	GameObject[] timer= new GameObject[2];
	// Use this for initialization
	void Start () {
		time_one = 0;
		time_ten = 3;
		timer [0] = gameObject.transform.Find ("time_one").gameObject;
		timer [1] = gameObject.transform.Find ("time_ten").gameObject;
		for (int i = 0; i < 10; i++) {
			number_image = string.Concat (imagenum);
			imagenum [6]++;
			number [i] = Resources.Load(number_image) as Sprite;
		}
		timerstart = true;
		StartCoroutine ("Timer");

		timer[0].GetComponent<Image> ().sprite = number [time_one];
		timer[1].GetComponent<Image> ().sprite = number [time_ten];

	}

	void Update () {
		if (time_one == 0 && time_ten == 0) {
			select_p1.SL_Decide = true;
			select_p2.SL_Decide = true;
		}
	}
	IEnumerator Timer()
		{
		while (true) {
			if (timerstart) {
				yield return new WaitForSecondsRealtime(1f);
				if (time_one >0){
					time_one--;
					time_ten--;
				} else
					time_one = 9;
			} else
				break;
		}
	}
}
