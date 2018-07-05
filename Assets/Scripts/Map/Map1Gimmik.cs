using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Gimmik : MonoBehaviour {
    int mapNum;

    GameObject map1Bullet;

	// Use this for initialization
	void Start () {
        mapNum = gameObject.GetComponent<MapManager>().mapNumber;
        map1Bullet = Resources.Load("Map/Map1Bullet2") as GameObject;

        Debug.Log("mapNum : " + mapNum);

        if (mapNum == 1)
        {
            StartCoroutine(Map1GimmikFunction());
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Map1GimmikFunction()
    {
        yield return new WaitForSeconds(10f);

        StartCoroutine(Map1Gimmik1());
    }

    IEnumerator Map1Gimmik1()
    {
        GameObject map1BulletTemp;
        float map1BulletRotation;

        Debug.Log("I'm playing");

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet, new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet, new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet, new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet, new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet, new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

    }
}
