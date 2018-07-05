using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill_2 : MonoBehaviour {
	Vector3 initial=new Vector3(0f,0f,0f);
	Vector3 distance=new Vector3(0f,0f,0f);
	GameObject bullet_skill2;
	GameObject bullet_Impact;
	Vector3 range = new Vector3 (5f, 0f, 0f);
	public GameObject Bullet_Mana;
	Vector3 bulletShootPosition = new Vector3(0f, 0f, 0f);
	public GameObject Bullet_Impact;
	GameObject[] bullet_im = new GameObject[4];
	bool skill;
	// Use this for initializat
	void Start () {
		skill = false;
		Bullet_Mana.GetComponent<BulletIdentifier> ().bulletSpd = 60f;
		bullet_im [0] = Bullet_Impact.transform.Find ("Skill_two_Impact_Right").gameObject;
		bullet_im [1] = Bullet_Impact.transform.Find ("Skill_two_Impact_Down").gameObject;
		bullet_im [2] = Bullet_Impact.transform.Find ("Skill_two_Impact_Up").gameObject;
		bullet_im [3] = Bullet_Impact.transform.Find ("Skill_two_Impact_Left").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (skill == true && (bullet_skill2.GetComponent<Transform> ().position.x > initial.x+distance.x-range.x)&&(bullet_skill2.GetComponent<Transform> ().position.x < initial.x+distance.x+range.x)) {
			bullet_Impact=Instantiate (Bullet_Impact);
			bullet_Impact.transform.position = bullet_skill2.transform.position;
			for(int i=0;i<4;i++)
				bullet_im[i].GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
			Destroy (bullet_skill2);
			skill = false;
		}
	}
	public void skill2()
	{
		if (gameObject.GetComponent<InputKey>().isPlayer == 1)
		{
			bulletShootPosition = new Vector3(30f, 0f, 0f);
		}
		else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
		{
			bulletShootPosition = new Vector3(-30f, 0f, 0f);
		}
		skill = true;
		bullet_skill2 = Instantiate(Bullet_Mana);
		bullet_skill2.transform.parent = GameObject.Find("BulletManager").transform;
		bullet_skill2.transform.position = bulletShootPosition + gameObject.transform.position;
		bullet_skill2.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;

		initial = bullet_skill2.transform.position;
		distance = new Vector3 (((float)gameObject.GetComponent<InputKey> ().isPlayer - 1.5f) * (-2f) * 90f, 0f, 0f);
		Debug.Log (initial.x+distance.x);
		Debug.Log (initial.y);
		Debug.Log (initial.z);
	}
}
