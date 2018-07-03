using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Temp : MonoBehaviour {

    public int isPlayer_BulletTemp;
    float speed_BulletTemp;
    Vector3 bullet_Rotation;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<BulletIdentifier>().bulletSpd = 20f;

        isPlayer_BulletTemp = gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet;

        if (isPlayer_BulletTemp == 1)
        {
            speed_BulletTemp *= 10;
            bullet_Rotation = new Vector3(20f, 20f, 1f);
        }
        else if (isPlayer_BulletTemp == 2)
        {
            speed_BulletTemp *= -10;
            bullet_Rotation = new Vector3(-20f, 20f, 1f);
        }

        gameObject.transform.localScale = bullet_Rotation;
	}
	
	// Update is called once per frame
	void Update () {
        speed_BulletTemp = gameObject.GetComponent<BulletIdentifier>().bulletSpd;
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

    void FixedUpdate()
    {
    }
}
