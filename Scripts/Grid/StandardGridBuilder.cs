using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StandardGridBuilder : IGridBuilder
{
	private readonly float spacing;
	private  BattleGrid battleGrid;

	private float initialZ = 0;

	public StandardGridBuilder(Vector3 startingPosition,float spacing)
	{
		this.spacing = spacing;
	}

	public GridElement[,] BuildGrid(int width, int length)
	{
		
		int gridFrequency = width * length;
		GridElement[,] gridElements = new GridElement[width,length];
		Vector3 elementPosition = Vector3.zero;
		elementPosition.x -= width / 2;
		elementPosition.z -= length / 2;
		initialZ = elementPosition.z;

		float increment = 1;

		//Tile positioning adjustments with an increase in tile frequency
		if ((width > 15 || length > 15) && (width < 18 || length < 18))
		{
			increment = 0.75f;
			CameraController.instance.RealignCamera();
		} else if (width >= 18 || length >= 18)
		{
			increment = 0.6f;
			CameraController.instance.RealignCamera();
		}
			


		for (int i = 0; i < width; i++)
		{
			elementPosition.x += increment + spacing;

			for (int j=0; j < length; j++)
			{
				
				elementPosition.z += increment + spacing;
				gridElements[i,j] = new StandardGridElement(elementPosition, battleGrid
					, new Vector2(i,j));
			}

			elementPosition.z = initialZ;

		}


		

		return gridElements;
	}


	public void SetBattleGrid(BattleGrid battleGrid)
	{
		if (battleGrid == null)
			throw new NullReferenceException("battlegrid parent is null");

		this.battleGrid = battleGrid;
	}
}
