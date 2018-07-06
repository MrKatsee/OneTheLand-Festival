using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana_skill4 : MonoBehaviour {

	public GameObject spear;
	GameObject bullet_skill4;
	float angle;
	float cos;
	float deltaheight;
	void Start () {
		
	}

	void Update () {
		
	}
	public void skill4()
	{
		StartCoroutine (skill4_active ());	
	}
	IEnumerator skill4_active()
	{
		int count=0;
		GetComponent<HPManagement> ().use=false;
		GetComponent<Diana_passive> ().skill4_use = true;
		GameObject cutIn;
		Debug.Log(GetComponent<Diana_skill_Active>().DianaSkillCutIn);
		cutIn = Instantiate(GetComponent<Diana_skill_Active>().DianaSkillCutIn, new Vector3(-1344f, 250f, -2f), Quaternion.identity);

		for (int i = 0; i < 96; i += 8)
		{
			cutIn.transform.position += new Vector3(112f, 0f, 0f);
			yield return new WaitForSeconds(0.01f);
		}

		yield return new WaitForSeconds(0.5f);

		for (int i = 96; i > 0; i -= 8)
		{
			cutIn.transform.position += new Vector3(112f, 0f, 0f);
			yield return new WaitForSeconds(0.01f);
		}
		cutIn.transform.position += new Vector3(56f, 0f, 0f);
		Destroy(cutIn);
		GetComponent<InputKey>().speed=12f;
		while(count<=10)
		{
			
			cos = (GetComponent<Skill_cNum2> ().target.x) / (Mathf.Sqrt (Mathf.Pow (GetComponent<Skill_cNum2> ().target.x, 2) + Mathf.Pow (GetComponent<Skill_cNum2> ().target.y, 2)));
			angle = Mathf.Acos (cos) * Mathf.Rad2Deg;
			Debug.Log (angle);
			deltaheight = (GetComponent<Skill_cNum2> ().oppP.y - GetComponent<Skill_cNum2> ().myP.y) / Mathf.Abs ((GetComponent<Skill_cNum2> ().oppP.y - GetComponent<Skill_cNum2> ().myP.y));
			bullet_skill4 = Instantiate(spear, GetComponent<Diana_passive>().bulletShootPosition + gameObject.transform.position, Quaternion.Euler(0f,0f,deltaheight*angle));
			bullet_skill4.transform.parent = GameObject.Find("BulletManager").transform;
			bullet_skill4.GetComponent<BulletIdentifier> ().bulletSpd = 30000f;
			bullet_skill4.GetComponent<Diana_skill4_attack>().angle=angle;
			bullet_skill4.GetComponent<Rigidbody2D>().velocity = bullet_skill4.GetComponent<BulletIdentifier>().bulletSpd*Time.deltaTime*GetComponent<Skill_cNum2>().target.normalized;
			bullet_skill4.GetComponent<BulletIdentifier>().isPlayer_Bullet = gameObject.GetComponent<InputKey>().isPlayer;
			bullet_skill4.GetComponent<BulletIdentifier> ().isDestroiable = false;
			count++;
			yield return new WaitForSeconds (2f-Time.deltaTime);
		}
		GetComponent<HPManagement> ().use=true;
		GetComponent<Diana_skill_Active>().skill4_end = true;
		GetComponent<Diana_passive> ().skill4_use = false;
		GetComponent<InputKey>().speed=10f;
	}
}
