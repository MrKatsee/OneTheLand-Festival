using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill_2 : MonoBehaviour {
	GameObject bullet_skill2;
	Vector2 direction;
	public GameObject Bullet_Mana;
	Vector3 bulletShootPosition = new Vector3(0f, 0f, 0f);
	public static int player;
	// Use this for initializat
	void Start () {
	}	
	void Update () {
		player = gameObject.GetComponent<InputKey> ().isPlayer;
	}
	public void skill2()
	{
		if (gameObject.GetComponent<InputKey>().isPlayer == 1)
		{
			bulletShootPosition = new Vector3(30f, 0f, 0f);
			direction = Vector2.right;
		}
		else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
		{
			bulletShootPosition = new Vector3(-30f, 0f, 0f);
			direction = Vector2.left;
		}
		bullet_skill2 = Instantiate(Bullet_Mana);
		bullet_skill2.transform.parent = GameObject.Find("BulletManager").transform;
		bullet_skill2.transform.position = bulletShootPosition + gameObject.transform.position;
		bullet_skill2.GetComponent<Rigidbody2D>().velocity = 400f*direction;
		bullet_skill2.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
		bullet_skill2.GetComponent<Diana_skill2_data>().initial = bullet_skill2.transform.position;
		bullet_skill2.GetComponent<Diana_skill2_data>().distance = new Vector3 (((float)gameObject.GetComponent<InputKey> ().isPlayer - 1.5f) * (-2f) * 600f, 0f, 0f);
	}

}
