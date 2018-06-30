using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
	void Awake()
	{
		if (Instance == null)
			Instance = this;
 
		else if (Instance != this)
			Destroy(gameObject);    
 
		DontDestroyOnLoad(gameObject);
 
		InitGame();
	}
 
	//Initializes the game for each level.
	void InitGame()
	{
		
	}
 
	void Update()
	{
 
	}

    public int characNum1 = 1;
    public int characNum2 = 2;
    public int mapNum;

}