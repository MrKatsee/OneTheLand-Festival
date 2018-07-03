using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_IrisSkill4 : MonoBehaviour {
    GameObject isBullet_IrisSkill4;
    public GameObject Bullet_IrisSkill4;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(1400f, 0f);
        isBullet_IrisSkill4 = GameObject.Find("BulletManager");
        StartCoroutine(TriggerEctasy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        GameObject bulletEctasy;
        if(c.transform.parent == isBullet_IrisSkill4.transform)
        {
            bulletEctasy = Instantiate(Bullet_IrisSkill4, c.transform.position + new Vector3(0f,0f,-1f), Quaternion.identity);
            Destroy(c.gameObject);
        }
    }

    IEnumerator TriggerEctasy()
    {
        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }
}
