using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterFrameImage : MonoBehaviour {

    public Image frame;
    public Sprite[] characImage = new Sprite[7];
    int cNum;
    public int isPlayer_frame;

	// Use this for initialization
	void Start () {
        if (isPlayer_frame == 1)
        {
            cNum = GameObject.Find("L_P1Start").GetComponent<BattleStart>().cNum;
        }
        if (isPlayer_frame == 2)
        {
            cNum = GameObject.Find("L_P2Start").GetComponent<BattleStart>().cNum;
        }

        if (cNum == 1)
        {
            frame.sprite = characImage[0];
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
