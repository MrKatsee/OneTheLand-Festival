using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill2_data : MonoBehaviour {

	public Vector3 initial=new Vector3(0f,0f,0f);
	public Vector3 distance=new Vector3(0f,0f,0f);
	Vector3 range = new Vector3 (5f, 0f, 0f);
	GameObject[] bullet_im = new GameObject[4];
	GameObject bullet_Impact;
	public GameObject Bullet_Impact;
	void Start()
	{
		bullet_im [0] = Bullet_Impact.transform.Find ("Skill_two_Impact_Right").gameObject;
		bullet_im [1] = Bullet_Impact.transform.Find ("Skill_two_Impact_Down").gameObject;
		bullet_im [2] = Bullet_Impact.transform.Find ("Skill_two_Impact_Up").gameObject;
		bullet_im [3] = Bullet_Impact.transform.Find ("Skill_two_Impact_Left").gameObject;
	}
	void Update()
	{
		if ((transform.position.x > initial.x + distance.x - range.x) &&
			(transform.position.x < initial.x + distance.x + range.x)) {
			bullet_Impact=Instantiate (Bullet_Impact);
			bullet_Impact.transform.position = transform.position;
			for(int i=0;i<4;i++)
				bullet_im[i].GetComponent<BulletIdentifier>().isPlayer_Bullet = Diana_skill2.player;
			Destroy (gameObject);
		}
	}
}
