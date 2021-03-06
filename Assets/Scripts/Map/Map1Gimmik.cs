﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map1Gimmik : MonoBehaviour {
    int mapNum;
    int gimmikCount = 1;

    GameObject[] map1Bullet = new GameObject[2];
    GameObject map1RazerCross;
    GameObject map1RazerVisual0;
    GameObject map1RazerVisual1;
    GameObject map1RazerVisual2;
    GameObject map1RazerDetector1;

    // Use this for initialization
    void Start () {
        mapNum = gameObject.GetComponent<MapManager>().mapNumber;
        map1Bullet[0] = Resources.Load("Map/Map1Bullet1") as GameObject;
        map1Bullet[1] = Resources.Load("Map/Map1Bullet2") as GameObject;
        map1RazerCross = Resources.Load("Map/Map1RazerCross") as GameObject;
        map1RazerVisual0 = Resources.Load("Map/Map1RazerVisual0") as GameObject;
        map1RazerVisual1 = Resources.Load("Map/Map1RazerVisual1") as GameObject;
        map1RazerVisual2 = Resources.Load("Map/Map1RazerVisual2") as GameObject;
        map1RazerDetector1 = Resources.Load("Map/Map1RazerDetector1") as GameObject;

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
        float countdown1 = 20f;
        float countdown2 = 10f;

        while (true)
        {
            yield return new WaitForSeconds(countdown1);

            StartCoroutine(Map1Gimmik1(gimmikCount));

            yield return new WaitForSeconds(countdown2);

            StartCoroutine(Map1Gimmik2());
        }


    }

    IEnumerator Map1Gimmik1(int count)
    {
        GameObject map1BulletTemp;
        float map1BulletRotation;

        Debug.Log("I'm playing");
        for (int j = 0; j < count; j++)
        {
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
        gimmikCount++;
    }

    IEnumerator Map1Gimmik2()
    {
        GameObject map1RazerCrossTemp;
        GameObject map1RazerDetectorTemp1;
        GameObject map1RazerDetectorTemp2;
        GameObject map1RazerVisual1Temp1;
        GameObject map1RazerVisual1Temp2;
        GameObject map1RazerVisual2Temp1;
        GameObject map1RazerVisual2Temp2;
        GameObject map1RazerVisual0Temp1;
        GameObject map1RazerVisual0Temp2;
        float map1RazerRotation;

        map1RazerCrossTemp = Instantiate(map1RazerCross, new Vector3(Random.Range(-400f, 400f), Random.Range(-250f, 250f), -1f), Quaternion.identity);

        yield return new WaitForSeconds(0.1f);

        map1RazerVisual0Temp1 = Instantiate(map1RazerVisual0, map1RazerCrossTemp.transform.position, Quaternion.identity);
        map1RazerVisual0Temp2 = Instantiate(map1RazerVisual0, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(90f, Vector3.forward));

        yield return new WaitForSeconds(1f);

        Destroy(map1RazerVisual0Temp1);
        Destroy(map1RazerVisual0Temp2);
        map1RazerVisual2Temp1 = Instantiate(map1RazerVisual2, map1RazerCrossTemp.transform.position, Quaternion.identity);
        map1RazerVisual2Temp2 = Instantiate(map1RazerVisual2, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(90f, Vector3.forward));

        yield return new WaitForSeconds(0.05f);

        Destroy(map1RazerVisual2Temp1);
        Destroy(map1RazerVisual2Temp2);
        map1RazerVisual1Temp1 = Instantiate(map1RazerVisual1, map1RazerCrossTemp.transform.position, Quaternion.identity);
        map1RazerVisual1Temp2 = Instantiate(map1RazerVisual1, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(90f, Vector3.forward));
        map1RazerDetectorTemp1 = Instantiate(map1RazerDetector1, map1RazerCrossTemp.transform.position, Quaternion.identity);
        map1RazerDetectorTemp1.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
        map1RazerDetectorTemp1.GetComponent<BulletIdentifier>().isDestroiable = false;
        map1RazerDetectorTemp2 = Instantiate(map1RazerDetector1, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(90f, Vector3.forward));
        map1RazerDetectorTemp2.GetComponent<BulletIdentifier>().isPlayer_Bullet = 3;
        map1RazerDetectorTemp2.GetComponent<BulletIdentifier>().isDestroiable = false;

        for (map1RazerRotation = 0f; map1RazerRotation < 45f; map1RazerRotation += Time.deltaTime * 22.5f)
        {
            map1RazerCrossTemp.GetComponent<Transform>().rotation = Quaternion.AngleAxis(map1RazerRotation, Vector3.forward);
            map1RazerVisual1Temp1.GetComponent<Transform>().rotation = Quaternion.AngleAxis(map1RazerRotation, Vector3.forward);
            map1RazerVisual1Temp2.GetComponent<Transform>().rotation = Quaternion.AngleAxis(map1RazerRotation + 90f, Vector3.forward);
            map1RazerDetectorTemp1.GetComponent<Transform>().rotation = Quaternion.AngleAxis(map1RazerRotation, Vector3.forward);
            map1RazerDetectorTemp2.GetComponent<Transform>().rotation = Quaternion.AngleAxis(map1RazerRotation + 90f, Vector3.forward);

            /*
            map1RazerVisual1Temp1.transform.Rotate(0f, 0f, map1RazerRotation);
            map1RazerVisual1Temp2.transform.Rotate(0f, 0f, map1RazerRotation);
            map1RazerDetectorTemp1.transform.Rotate(0f, 0f, map1RazerRotation);
            map1RazerDetectorTemp2.transform.Rotate(0f, 0f, map1RazerRotation);
            */
            yield return null;
        }

        yield return new WaitForSeconds(1f);

        Destroy(map1RazerVisual1Temp1);
        Destroy(map1RazerVisual1Temp2);
        map1RazerVisual2Temp1 = Instantiate(map1RazerVisual2, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(-45f, Vector3.forward));
        map1RazerVisual2Temp2 = Instantiate(map1RazerVisual2, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(45f, Vector3.forward));

        yield return new WaitForSeconds(0.05f);

        Destroy(map1RazerVisual2Temp1);
        Destroy(map1RazerVisual2Temp2);
        map1RazerVisual0Temp1 = Instantiate(map1RazerVisual0, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(-45f, Vector3.forward));
        map1RazerVisual0Temp2 = Instantiate(map1RazerVisual0, map1RazerCrossTemp.transform.position, Quaternion.AngleAxis(45f, Vector3.forward));

        yield return new WaitForSeconds(0.05f);

        Destroy(map1RazerVisual0Temp1);
        Destroy(map1RazerVisual0Temp2);

        yield return new WaitForSeconds(0.1f);

        Destroy(map1RazerCrossTemp);


    }

}
