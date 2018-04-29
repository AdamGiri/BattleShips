using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class BattleGrid  {

	public int Width { get; private set; }
	public int Length { get; private set; }
	public static Player GridOwner { get; private set; }
	public IGridBuilder GridBuilder { get; private set; }
	public GridElement[,] gridElements { get; protected set; }
	public GameObject battleGrid { get; private set; }

	protected int _maxWidth = 20;
	protected int _maxLength = 20;
	protected int _minWidth = 6;
	protected int _minLength = 6;

	public  BattleGrid(int width, int length, Player gridOwner, IGridBuilder gridBuilder)
	{
		
		AreDimensionsValid(width, length);
		Width = width;
		Length = length;

		if (gridOwner == null)
			throw new NullReferenceException("Player is null");
		GridOwner = gridOwner;

		if (gridBuilder == null)
			throw new NullReferenceException("GridBuilder is null");
		GridBuilder = gridBuilder;
		GridBuilder.SetBattleGrid(this);

		SetGrid(gridOwner.PlayerSide);

		
		gridElements = GridBuilder.BuildGrid(Width, Length);
	}



	private void AreDimensionsValid(int width, int length)
	{
		if (width > _maxWidth || width < _minWidth || length > _maxLength || length < _minWidth)
			throw new InvalidOperationException("Grid dimensions are out of bounds");
			
	}

	private void SetGrid(Player.PlayerPosition playerPosition)
	{
		
		string side;

		if (playerPosition == Player.PlayerPosition.LEFT)
			side = "LeftGrid";
		else
			side = "RightGrid";

		battleGrid = GameObject.Find(side);
		battleGrid.transform.localScale += new Vector3(Width-1, 0, Length-1);
		
	}

	//calculates whether the grid elements are free to accept the game object, declared
	// abstract because I don't want to tightly couple this with boat objects - only in subclass
	public abstract void CalculateObjectSpaceAvailability(Vector2 arrayPosition);
}
