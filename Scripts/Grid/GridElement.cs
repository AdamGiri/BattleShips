using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class GridElement  {

	protected readonly BattleGrid gridParent;

	public GameObject gridElementGameObject { get; protected set; }

	public Vector3 PositionInGrid { get; private set; }
	public Vector2 ArrayPosition { get; private set; }

	public GridElement(Vector3 positionInGrid, BattleGrid gridParent, Vector2 arrayPosition)
	{
		PositionInGrid = positionInGrid;
		this.gridParent = gridParent;
		ArrayPosition = arrayPosition;
		SetGridElementTransform();
	}


	protected virtual void SetGridElementTransform()
	{
		//create a basic plane for each grid element and set its parent as the grid and position it
		gridElementGameObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
		gridElementGameObject.GetComponent<Renderer>().material.color = Color.blue;
		gridElementGameObject.transform.SetParent(gridParent.battleGrid.transform);
		gridElementGameObject.transform.localPosition = PositionInGrid;
		gridElementGameObject.AddComponent<GridElementMouseHover>().SetGridElement(this);
	}

	//color grid elements  green if available / red if not available
	protected virtual void ActivateGridElement(Color color)
	{
		if (color == Color.green)
		{
			gridElementGameObject.transform.GetComponent<Renderer>().material.color = Color.green;
		}
		else if (color == Color.red){
			gridElementGameObject.transform.GetComponent<Renderer>().material.color = Color.red;
		}
			
	}

	public  void QueryGridForObjectSpace()
	{
		gridParent.CalculateObjectSpaceAvailability(ArrayPosition);
	}

}
