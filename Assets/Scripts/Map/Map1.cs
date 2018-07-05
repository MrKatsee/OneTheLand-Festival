using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Map1 : MonoBehaviour {

    int mapNumber1;

    public GameObject[] map1Bullet = new GameObject[2];

	// Use this for initialization
	void Start () {
        mapNumber1 = GetComponent<MapManager>().mapNumber;

        MapStartCoroutine(mapNumber1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void MapStartCoroutine(int mapNumber)
    {
        if (mapNumber == 1)
        {
            StartCoroutine(Map1Coroutine());
        }
    }

    IEnumerator Map1Coroutine()
    {
        GameObject[] map1BulletTemp = new GameObject[30];
        float map1BulletRotation;

        yield return new WaitForSeconds(1f);

        for (int i = 0; i < 30; i++)
        {
            map1BulletRotation = i / 30f;
            map1BulletTemp[i] = Instantiate(map1Bullet[1], new Vector3 (0f, 0f, -1f), Quaternion.identity);
            // map1Bullet[i].GetComponent<Bullet_IrisSkill2Ef>().IS2BBEf_Angle = irisBombBulletRotation;
            // Destroy(map1BulletTemp[i], 3f);
        }
    }
}
