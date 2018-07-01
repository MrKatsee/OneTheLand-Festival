using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SL_Map : MonoBehaviour {


	public Sprite[] Ch_Ir= new Sprite[7];
	void Update () {
		gameObject.GetComponent<Image>().sprite= Ch_Ir [Data.Map - 1];
		
	}
}
