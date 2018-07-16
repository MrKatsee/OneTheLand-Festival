using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill4_attack : MonoBehaviour {
	public GameObject skill4_bullet;
	Vector3 position;
	public float angle;
	float timer=0;
	int count;
	GameObject bullet1;
	GameObject bullet2;
	GameObject bullet3;
	GameObject bullet4;
	float speed=100f;
	void Start()
	{
		StartCoroutine (skill4());
	}
	IEnumerator skill4()
	{
		timer = 0;
		count = 1;
		while (timer < 5f) {
			timer += Time.deltaTime;
			if (timer >= 0.2f * count) {
				count++;
				position = transform.position;
				yield return StartCoroutine (bullet_ ());
			}
			else
				yield return null;
		}
		Destroy (gameObject);
	}
	IEnumerator bullet_()
	{
		bullet1 = Instantiate (skill4_bullet,position+new Vector3(Mathf.Cos(angle+90),Mathf.Sin(angle+90),0f)*1.2f,Quaternion.identity);
		bullet2 = Instantiate (skill4_bullet,position+new Vector3(Mathf.Cos(angle+90),Mathf.Sin(angle+90),0f)*0.6f,Quaternion.identity);
		bullet3 = Instantiate (skill4_bullet,position-new Vector3(Mathf.Cos(angle+90),Mathf.Sin(angle+90),0f)*1.2f,Quaternion.identity);
		bullet4 = Instantiate (skill4_bullet,position-new Vector3(Mathf.Cos(angle+90),Mathf.Sin(angle+90),0f)*0.6f,Quaternion.identity);
		creating_bullet (bullet1,angle+90);
		creating_bullet (bullet2,angle+90);
		creating_bullet (bullet3,angle-90);
		creating_bullet (bullet4,angle-90);
		yield return null;
	}
	void creating_bullet(GameObject bullet, float angles)
	{
		bullet.transform.parent = GameObject.Find("BulletManager").transform;
		bullet.GetComponent<BulletIdentifier> ().isPlayer_Bullet = gameObject.GetComponent<BulletIdentifier> ().isPlayer_Bullet;
		bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (Mathf.Cos (angles), Mathf.Sin (angles)) * speed;
	}
}
