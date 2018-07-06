using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour {

    public float speed;
    public int isPlayer;
    public int canMove = 1;
    float spd;
    public bool gamePuase_Input;
    GameObject wall;

    // Use this for initialization
    void Start () {
		speed = 10;
        spd = speed * Time.deltaTime;

    }

    // Update is called once per frame

	
	// Update is called once per frame
	void Update () {
		spd = speed * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.T) && isPlayer == 1)
        {
            gameObject.GetComponent<HPManagement>().AltSkillGuageUse();
        }
        if (Input.GetKeyUp(KeyCode.T) && isPlayer == 1)
        {
            gameObject.GetComponent<HPManagement>().SkillUseTrigger();
        }
        if (Input.GetKey(KeyCode.Y) && isPlayer == 1)
        {
            gameObject.GetComponent<HPManagement>().SkillGuageCancle();
        }
        if (Input.GetKey(KeyCode.M) && isPlayer == 2)
        {
            gameObject.GetComponent<HPManagement>().AltSkillGuageUse();
        }
		if (Input.GetKeyUp(KeyCode.M) && isPlayer == 2)
		{
			gameObject.GetComponent<HPManagement>().SkillUseTrigger();
		}
        if (Input.GetKey(KeyCode.Comma) && isPlayer == 2)
        {
            gameObject.GetComponent<HPManagement>().SkillGuageCancle();
        }

        gamePuase_Input = GameManager.Instance.gamePause;
    }

    void FixedUpdate()
    {
        if (isPlayer == 1 && canMove == 1)
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y < 360)
            {
                transform.Translate(0f, spd * 20f, 0f);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y > -360)
            {
                transform.Translate(0f, spd * -20f, 0f);
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x > -640)
            {
                transform.Translate(spd * -20f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < 0)
            {
                transform.Translate(spd * 20f, 0f, 0f);
            }
        }

        if (isPlayer == 2 && canMove == 1 && gamePuase_Input == false)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 360)
            {
                transform.Translate(0f, spd * 20f, 0f);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -360)
            {
                transform.Translate(0f, spd * -20f, 0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 0)
            {
                transform.Translate(spd * -20f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 640)
            {
                transform.Translate(spd * 20f, 0f, 0f);
            }
        }
    }


}
