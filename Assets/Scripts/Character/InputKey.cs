using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour {

    public float speed;
    public int isPlayer;
    public int canMove = 1;
<<<<<<< HEAD
    float spd;
    public bool gamePuase_Input;


    // Use this for initialization
    void Start () {
		speed = 10;
        spd = speed * Time.deltaTime;

    }

    // Update is called once per frame
    void Update () {
        if (isPlayer == 1 && canMove == 1 && gamePuase_Input == false)
=======
	float spd;
	// Use this for initialization
	void Start () {
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		spd = speed * Time.deltaTime;
        if (isPlayer == 1 && canMove == 1)
>>>>>>> 7b6d5452da9a616f36783f4f3b54d6b894ae6991
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

        if (isPlayer == 2 && canMove == 1 && gamePuase_Input == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0f, spd * 20f, 0f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0f, spd * -20f, 0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(spd * -20f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(spd * 20f, 0f, 0f);
            }
        }

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
        if (Input.GetKey(KeyCode.N) && isPlayer == 2)
        {
            gameObject.GetComponent<HPManagement>().AltSkillGuageUse();
<<<<<<< HEAD
        }
=======

		}
		if (Input.GetKey(KeyCode.M) && isPlayer == 2)
		{
			gameObject.GetComponent<HPManagement>().SkillUseTrigger();
		}
>>>>>>> 7b6d5452da9a616f36783f4f3b54d6b894ae6991
        if (Input.GetKeyUp(KeyCode.N) && isPlayer == 2)
        {
            gameObject.GetComponent<HPManagement>().SkillGuageCancle();
        }
        if (Input.GetKey(KeyCode.M) && isPlayer == 2)
        {
            gameObject.GetComponent<HPManagement>().SkillGuageCancle();
        }

        gamePuase_Input = GameManager.Instance.gamePause;
    }
}
