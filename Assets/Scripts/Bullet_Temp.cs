using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Temp : MonoBehaviour {

    public int isPlayer_BulletTemp;
    Rigidbody r;
    public int speed_BulletTemp;

	// Use this for initialization
	void Start () {
        if (isPlayer_BulletTemp == 1)
        {
            speed_BulletTemp *= 1;
        }
        else if (isPlayer_BulletTemp == 2)
        {
            speed_BulletTemp *= -1;
        }

        r.velocity = new Vector3(1f * speed_BulletTemp, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
