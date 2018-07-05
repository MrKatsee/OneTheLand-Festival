using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour {
    public int mapNumber;
    public Sprite[] mapImageAry = new Sprite[7];
    public SpriteRenderer mapImageRenderer;

    void Awake ()
    {
        //mapNumber = GameManager.Instance.mapNum;
        mapNumber = 1;
    }

    // Use this for initialization
    void Start () {

        mapImageRenderer = GetComponent<SpriteRenderer>();

        MapChange(mapNumber);


    }

    // Update is called once per frame
    void Update () {
		
	}

    void MapChange(int num)
    {
        mapImageRenderer.sprite = mapImageAry[num - 1];

    }
}
