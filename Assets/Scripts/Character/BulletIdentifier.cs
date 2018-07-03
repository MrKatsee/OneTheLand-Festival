using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIdentifier : MonoBehaviour {

    public int isPlayer_Bullet;
    public float bulletSpd;
    public int isBullet;
    GameObject isInBulletManager;

    // Use this for initialization
    void Start () {
        isInBulletManager = GameObject.Find("BulletManager");
    }

    // Update is called once per frame
    void Update () {
		if (GameManager.Instance.gamePause == true && gameObject.transform.parent == isInBulletManager.transform)
        {
            bulletSpd = 0f;
        }
	}
}
