using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStart : MonoBehaviour {
    public int cNum;
    public int pNum;
    Vector3 p_location = new Vector3(0f, 0f, 0f);
    Vector3 p_rotation = new Vector3(0f, 0f, 0f);
    public GameObject[] Charac = new GameObject[7];
	public static GameObject player1;
	public static GameObject player2;
    public int startHP;
    public Vector2 p1P;
    public Vector2 p2P;

	// Use this for initialization
    void Awake()
    {
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
    }

	void Start () {
        //character selection
        

        p_location = gameObject.transform.position;

        if (pNum == 1)
            p_rotation = new Vector3(10f, 10f, 1f);

        else if (pNum == 2)
            p_rotation = new Vector3(-10f, 10f, 1f);

        if (cNum == 1)
        {
			player1= Instantiate(Charac[0], p_location, Quaternion.identity);
			player1.transform.localScale = p_rotation;
			player1.GetComponent<InputKey>().isPlayer = pNum;
        }

        if (cNum == 2)
        {
			player2 = Instantiate(Charac[1], p_location, Quaternion.identity);
			player2.transform.localScale = p_rotation;
			player2.GetComponent<InputKey>().isPlayer = pNum;
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
