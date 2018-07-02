using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_passive : MonoBehaviour {

	int Bullet_Speed;
	float spd;
	public GameObject nomalBullet;
	GameObject bullet_temp;
	Vector3 bulletShootPosition = new Vector3(0f, 0f, 0f);
	public static int Bullet_count;
	float time;

	void Awake()
	{
		Bullet_Speed=50;
		spd = Bullet_Speed * Time.deltaTime;
	}

	void Start()
	{
		if (gameObject.GetComponent<InputKey>().isPlayer == 1)
		{
			bulletShootPosition = new Vector3(30f, 0f, 0f);
		}
		else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
		{
			bulletShootPosition = new Vector3(-30f, 0f, 0f);
		}
		Bullet_count = 1;
		StartCoroutine(Diana_Attack(nomalBullet));
	}

	void Update () {
		//기본 공격 - x축과 평행한 방향으로 0.3초 간격으로 탄환 6발을 발사한다 
		//6발 발사 후 1.5초 장전 시간을 가진다
	}
	IEnumerator Diana_Attack(GameObject Diana_Bullet)
	{
		while (true)
		{
			if (Bullet_count > 6) {
				Bullet_count = 1;
				yield return new WaitForSeconds(1.5f * spd);
			} else {
				Bullet_count++;
				bullet_temp = Instantiate(Diana_Bullet);
				bullet_temp.transform.position = bulletShootPosition + gameObject.transform.position;
				bullet_temp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
				Destroy(bullet_temp, 5f);
				yield return new WaitForSeconds(0.3f * spd);
			}
		}
	}
}
