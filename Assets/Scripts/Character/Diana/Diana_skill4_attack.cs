using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill4_attack : MonoBehaviour {
	public GameObject skill4_bullet;
	GameObject bullet;
	Vector3 position_initial;
	Vector3 position_final=new Vector3(0f,0f,0f);
	Vector3 position_distance;
	Vector3 position_layer;
	public float direct_x;
	public float direct_y;
	public float angle;
	float timer;
	// Use this for initialization
	void Start () {
		position_distance=new Vector3(direct_x,direct_y,0f).normalized;
		position_distance.x *= 45;
		position_distance.y *= 45;
		position_layer=new Vector3(direct_x,direct_y,0f).normalized;
		position_layer.x *= 10;
		position_layer.y *= 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void creating_bullet()
	{
		StartCoroutine (Creative_bullet ());
	}
	IEnumerator Creative_bullet()
	{
		timer = 0;
		while (timer < 10f) {
			timer += Time.deltaTime;
			position_initial = transform.position;
			yield return StartCoroutine(fly_spear());
		}
		Destroy (gameObject);
	}
	IEnumerator fly_spear()
	{
		while ((position_final.x >= position_initial.x + position_distance.x*0.9f&& position_final.x<= position_initial.x + position_distance.x*1.1f)
			&&(position_final.y >= position_initial.y + position_distance.y*0.9f&& position_final.y<= position_initial.y + position_distance.y*1.1f)) {
			timer += Time.deltaTime;
			position_final = transform.position;
		}
		Instantiate_Bullet ((position_final + position_initial) / 2f+position_layer, angle+90);
		Instantiate_Bullet ((position_final + position_initial) / 2f-position_layer, angle+90);
		Instantiate_Bullet ((position_final + position_initial) / 2f+position_layer, angle-90);
		Instantiate_Bullet ((position_final + position_initial) / 2f-position_layer, angle-90);
		yield return null;
	}
	void Instantiate_Bullet(Vector3 position,float angle)
	{
		bullet = Instantiate (skill4_bullet, position,Quaternion.Euler(0f,0f,angle));
		bullet.transform.parent = GameObject.Find("BulletManager").transform;
		bullet.GetComponent<Rigidbody2D>().velocity = 10f*new Vector2(direct_x,direct_y);
		bullet.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet;
		Destroy(bullet, 5f);
	}
}
