using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public static bool Gameover=false;
	public static int player=0;
	public GameObject Gameover_object;
	public GameObject Gameover_reverse;
	GameObject Gameover_UI;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Gameover == true) {
			Gameover_UI=Instantiate(Gameover_object);
			Gameover_UI.transform.SetParent(GameObject.Find ("BattleUI").GetComponent<Canvas> ().transform, false);
			Gameover_UI.GetComponent<RectTransform> ().position = new Vector3 (0f, 150f, 0f);
			Gameover_UI=Instantiate(Gameover_reverse);
			Gameover_UI.transform.SetParent(GameObject.Find ("BattleUI").GetComponent<Canvas> ().transform, false);
			Gameover_UI.GetComponent<RectTransform> ().position = new Vector3 (0f, -120f, 0f);
			Time.timeScale = 0;
			if (player == 1) {
				BattleStart.player1.transform.position = new Vector3 (0f, 0f, 0f);
			}
			else if (player == 2) {
				BattleStart.player2.transform.position = new Vector3 (0f, 0f, 0f);
			}
			Gameover = false;
		}
	}
}
