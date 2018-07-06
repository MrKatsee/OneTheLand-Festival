using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
{
	public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
    public static GameManager Instance
    {
        get { return GetInstance(); }
    }
    public static GameManager GetInstance()
	{
		if (instance == null)
            instance = new GameManager();
        return instance;
    }


    GameManager()
    {
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
	{

	}

    public int characNum1 = 1;
    public int characNum2 = 2;
    public bool gamePause;
    public int mapNum;

}