using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour {

    public float speed;
    public int isplayer;
    float spd;

	// Use this for initialization
	void Start () {
        spd = speed * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        if (isplayer == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0f, spd * 20f, 0f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0f, spd * -20f, 0f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(spd * -20f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(spd * 20f, 0f, 0f);
            }
        }
	}
}
