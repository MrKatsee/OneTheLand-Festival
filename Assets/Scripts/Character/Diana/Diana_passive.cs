using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diana_passive : MonoBehaviour {
	
	public GameObject Bullet_UI_Fill;
	public GameObject Bullet_UI_Null;
	GameObject[] Bullet_UI_temp;
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
		Bullet_count = 6;
		Bullet_UI_temp = new GameObject[Bullet_count];
		if (gameObject.GetComponent<InputKey>().isPlayer == 1)
		{
			bulletShootPosition = new Vector3(30f, 0f, 0f);
		}
		else if (gameObject.GetComponent<InputKey>().isPlayer == 2)
		{
			bulletShootPosition = new Vector3(-30f, 0f, 0f);
		}

		for (int i = 0; i < Bullet_count && gameObject.GetComponent<InputKey>().isPlayer == 1; i++) {
			Bullet_UI_temp[i]=Instantiate(Bullet_UI_Fill);
			Bullet_UI_temp[i].transform.SetParent(GameObject.Find ("BattleUI").GetComponent<Canvas> ().transform, false);
			Bullet_UI_temp[i].GetComponent<RectTransform> ().position = new Vector3 (-400f+i*40f, -195f, 0f);
            Bullet_UI_temp[i].transform.localScale = new Vector3(((float)gameObject.GetComponent<InputKey>().isPlayer-1.5f)*(-2f), 1f,0f);
		}

        for (int i = 0; i < Bullet_count && gameObject.GetComponent<InputKey>().isPlayer == 2; i++)
        {
            Bullet_UI_temp[i] = Instantiate(Bullet_UI_Fill);
            Bullet_UI_temp[i].transform.SetParent(GameObject.Find("BattleUI").GetComponent<Canvas>().transform, false);
            Bullet_UI_temp[i].GetComponent<RectTransform>().position = new Vector3(400f + (-1) * i * 40f, -195f, 0f);
            Bullet_UI_temp[i].transform.localScale = new Vector3(((float)gameObject.GetComponent<InputKey>().isPlayer - 1.5f) * (-2f), 1f, 0f);
        }

        StartCoroutine(Diana_Attack(nomalBullet));
	}
	void Update () {
		//기본 공격 - x축과 평행한 방향으로 0.3초 간격으로 탄환 6발을 발사한다 
		//6발 발사 후 1.5초 장전 시간을 가진다
	}
	public void skill1()
	{
		Bullet_count = 6;
		gameObject.GetComponent<InputKey>().speed= 12;
		Invoke ("slow", 3f);
	}
	void slow()
	{
		gameObject.GetComponent<InputKey>().speed= 10;
	}
	IEnumerator Diana_Attack(GameObject Diana_Bullet)
	{
		while (true)
		{
			if (Bullet_count < 1) {
				Bullet_count = 6;
				for (int i = 0; i < Bullet_count; i++) {
					Bullet_UI_temp[i]=Bullet_UI_Fill;
				}
				yield return new WaitForSeconds(1.5f * spd);
			} else {
				Bullet_UI_temp[(Bullet_count--)-1]=Bullet_UI_Null;
				bullet_temp = Instantiate(Diana_Bullet);
                bullet_temp.transform.parent = GameObject.Find("BulletManager").transform;
                bullet_temp.transform.position = bulletShootPosition + gameObject.transform.position;
				bullet_temp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
				Destroy(bullet_temp, 5f);
				yield return new WaitForSeconds(0.3f * spd);
			}
		}
	}
}
