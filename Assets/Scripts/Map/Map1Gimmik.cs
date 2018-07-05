using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Gimmik : MonoBehaviour {
    int mapNum;

    GameObject[] map1Bullet = new GameObject[2];
    GameObject map1RazerCross;
    GameObject map1RazerVisual1;
    GameObject map1RazerVisual2;

    GameObject map1RazerDetector1;
    GameObject map1RazerDetector2;

    // Use this for initialization
    void Start () {
        mapNum = gameObject.GetComponent<MapManager>().mapNumber;
        map1Bullet[0] = Resources.Load("Map/Map1Bullet1") as GameObject;
        map1Bullet[1] = Resources.Load("Map/Map1Bullet2") as GameObject;
        map1RazerCross = Resources.Load("Map/Map1RazerCross") as GameObject;
        map1RazerVisual1 = Resources.Load("Map/Map1RazerVisual1") as GameObject;
        map1RazerVisual2 = Resources.Load("Map/Map1RazerVisual2") as GameObject;
        map1RazerDetector1 = Resources.Load("Map/Map1RazerDetector1") as GameObject;
        map1RazerDetector2 = Resources.Load("Map/Map1RazerDetector2") as GameObject;

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

        //StartCoroutine(Map1Gimmik1());
        StartCoroutine(Map1Gimmik2());

    }

    IEnumerator Map1Gimmik1()
    {
        GameObject map1BulletTemp;
        float map1BulletRotation;

        Debug.Log("I'm playing");

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet[(int)Random.Range(0f, 1.9f)], new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
            map1BulletTemp.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet[(int)Random.Range(0f, 1.9f)], new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
            map1BulletTemp.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet[(int)Random.Range(0f, 1.9f)], new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
            map1BulletTemp.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet[(int)Random.Range(0f, 1.9f)], new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
            map1BulletTemp.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 24; i++)
        {
            map1BulletRotation = i / 24f;

            map1BulletTemp = Instantiate(map1Bullet[(int)Random.Range(0f, 1.9f)], new Vector3(0f, 0f, -1f), Quaternion.identity);
            map1BulletTemp.transform.parent = GameObject.Find("BulletManager").transform;
            map1BulletTemp.gameObject.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
            map1BulletTemp.transform.Rotate(0f, 0f, Random.Range(0f, 360f));

            map1BulletTemp.GetComponent<BulletMap1_1>().bulletMap1_Rotation = map1BulletRotation;
        }
        yield return new WaitForSeconds(2f);

    }

    IEnumerator Map1Gimmik2()
    {
        GameObject map1RazerCrossTemp;
        GameObject map1RazerDetectorTemp1;
        GameObject map1RazerDetectorTemp2;
        GameObject map1RazerVisualTemp1;
        GameObject map1RazerVisualTemp2;

        map1RazerCrossTemp = Instantiate(map1RazerCross, new Vector3(0f, 0f, 0f), Quaternion.identity);

        yield return new WaitForSeconds(1f);

        map1RazerVisualTemp1 = Instantiate(map1RazerVisual1, new Vector3(0f, 0f, 0f), Quaternion.identity);
        map1RazerVisualTemp2 = Instantiate(map1RazerVisual2, new Vector3(0f, 0f, 0f), Quaternion.identity);
        map1RazerDetectorTemp1 = Instantiate(map1RazerDetector1, new Vector3(0f, 0f, 0f), Quaternion.identity);
        map1RazerDetectorTemp1.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
        map1RazerDetectorTemp1.GetComponent<BulletIdentifier>().isDestroiable = false;
        map1RazerDetectorTemp2 = Instantiate(map1RazerDetector2, new Vector3(0f, 0f, 0f), Quaternion.identity);
        map1RazerDetectorTemp2.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
        map1RazerDetectorTemp2.GetComponent<BulletIdentifier>().isDestroiable = false;

    }

}
