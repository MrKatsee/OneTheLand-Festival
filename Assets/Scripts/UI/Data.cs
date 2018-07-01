using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {

	public static int P1;
	public static int P2;
	public static int Map;
	public static GameObject UI_Ch;
	public static GameObject UI_BG;
	void Awake()
	{
		UI_Ch = GameObject.Find ("UI_Ch_SL");
		UI_BG = GameObject.Find ("UI_BG_SL");
	}
}
