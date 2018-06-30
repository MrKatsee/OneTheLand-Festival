using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ch_SL_P1 : MonoBehaviour {


	public Sprite[] Ch_Ir= new Sprite[7];

	void Update () {

		gameObject.GetComponent<Image>().sprite= Ch_Ir [Data.P1 - 1];
	}
}
