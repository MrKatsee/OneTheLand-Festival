using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStart : MonoBehaviour {
    public int cNum;
    public int pNum;
    Vector3 p_location = new Vector3(0f, 0f, 0f);
    Vector3 p_rotation = new Vector3(0f, 0f, 0f);
    public GameObject[] Charac = new GameObject[7];
    GameObject temp;
    public int startHP;
    public Vector2 p1P;
    public Vector2 p2P;

	// Use this for initialization
	void Start () {
        //character selection
        if (pNum == 1)
        {
            cNum = GameManager.Instance.characNum1;
            cNum = 1;
        }

        else if (pNum == 2)
        {
            cNum = GameManager.Instance.characNum2;
            cNum = 2;
        }

        p_location = gameObject.transform.position;

        if (pNum == 1)
            p_rotation = new Vector3(10f, 10f, 1f);

        else if (pNum == 2)
            p_rotation = new Vector3(-10f, 10f, 1f);

        if (cNum == 1)
        {
            GameObject temp = Instantiate(Charac[0], p_location, Quaternion.identity);
            temp.transform.localScale = p_rotation;
            temp.GetComponent<InputKey>().isPlayer = pNum;
        }

        if (cNum == 2)
        {
            GameObject temp = Instantiate(Charac[1], p_location, Quaternion.identity);
            temp.transform.localScale = p_rotation;
            temp.GetComponent<InputKey>().isPlayer = pNum;
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
