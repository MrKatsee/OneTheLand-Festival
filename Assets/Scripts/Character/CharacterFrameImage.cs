using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterFrameImage : MonoBehaviour {

    public Image frame;
    public Sprite[] characImage = new Sprite[7];
    public int cNum_Frame;
    public int isPlayer_frame;
    GameObject frameTemp;

	// Use this for initialization
	void Start () {
        frame = GetComponent<Image>();

        if (isPlayer_frame == 1)
        {
            frameTemp = GameObject.Find("L_P1Start");
            cNum_Frame = frameTemp.GetComponent<BattleStart>().cNum;
        }
        else if (isPlayer_frame == 2)
        {
            frameTemp = GameObject.Find("L_P2Start");
            cNum_Frame = frameTemp.GetComponent<BattleStart>().cNum;
        }

        if (cNum_Frame == 1)
        {
            frame.sprite = characImage[0];
        }
        if (cNum_Frame == 2)
        {
            frame.sprite = characImage[1];
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
