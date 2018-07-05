using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill3 : MonoBehaviour {
	public float Bullet_rotation;
	int i_temp=0;
	GameObject[] bullet_temp = new GameObject[30];
	void Start () {
		
		//Bullet_rotation= new Quaternion(0f, Random.Range(-10f, 10f), 0f);
	}
	
	void Update () {
		if (i_temp == 30) {
			i_temp = 0;
		}
	}
	public void skill3()
	{
		StartCoroutine (forward_attack(gameObject.GetComponent<Diana_passive>().nomalBullet));
	}
	IEnumerator forward_attack(GameObject skill_Bullet)
	{
		while (true){
			Bullet_rotation = Random.Range (-45f, 45f);
			bullet_temp[i_temp] = Instantiate(skill_Bullet,gameObject.GetComponent<Diana_passive>().bulletShootPosition+ gameObject.transform.position,Quaternion.Euler(0, 0, Bullet_rotation));
			bullet_temp [i_temp].GetComponent<Bullet_Temp> ().angle = Bullet_rotation;
			bullet_temp[i_temp].transform.parent = GameObject.Find("BulletManager").transform;
			bullet_temp[i_temp].gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
			i_temp++;
			if (i_temp == 30) {
				break;
			}
			yield return new WaitForSeconds (0.1f);
		}

	}
}
