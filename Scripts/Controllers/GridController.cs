using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GridController : MonoBehaviour {

	public static GridController instance = null;

	public BattleGrid[] Grid { get; private set; }

	[SerializeField]
	private int gridWidth = 12;
	[SerializeField]
	private int gridLength = 12;


	void Awake()
	{

		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}
	

	void Update () {
		
	}


	public void CreateGrids(Player[] players)
	{
		if (players == null)
			throw new NullReferenceException("Player collection is null");

		int playerFreq = players.Length;
		Grid = new BattleGrid[playerFreq];



		//creating standard battle grids for each player of gridWidthXgridLength dimension
		for (int i=0;i < playerFreq; i++)
		{
			
			Grid[i] = new StandardBattleGrid(gridWidth, gridLength, players[i]
		, new StandardGridBuilder(Vector3.zero,0));
		}
	}
}
