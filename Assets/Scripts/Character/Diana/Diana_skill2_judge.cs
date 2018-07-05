using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill2_judge : MonoBehaviour {

	void Update () {
		Invoke ("Destory_myself", 2f);
	}
	void Destory_myself()
	{
		Destroy (gameObject);
	}
}
