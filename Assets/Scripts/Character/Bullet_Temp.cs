using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Temp : MonoBehaviour {

    public int isPlayer_BulletTemp;
    public int speed_BulletTemp;

	// Use this for initialization
	void Start () {
        isPlayer_BulletTemp = gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet;

        if (isPlayer_BulletTemp == 1)
        {
            speed_BulletTemp *= 10;
        }
        else if (isPlayer_BulletTemp == 2)
        {
            speed_BulletTemp *= -10;
        }

        GetComponent<Rigidbody2D>().velocity = speed_BulletTemp * Vector2.right;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
