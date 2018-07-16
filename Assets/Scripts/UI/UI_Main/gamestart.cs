using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestart : MonoBehaviour {


	public void ButtonClick()
	{
		SceneManager.LoadScene("SL_UI");
		Time.timeScale = 1;
	}
}
