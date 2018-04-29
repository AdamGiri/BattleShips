using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//script attached to every grid element in order to detect mouse hover
public class GridElementMouseHover : MonoBehaviour {

	private GridElement _gridElement;

	private void OnMouseOver()
	{
		//get boat dimensions from grid parent and find grid elements that it will cover
		_gridElement.QueryGridForObjectSpace();
	

	}

	private void OnMouseExit()
	{

		transform.GetComponent<Renderer>().material.color = Color.blue;
	}

	public void SetGridElement(GridElement gridElement)
	{
		if (gridElement == null)
			throw new ArgumentNullException("Gridelement is null");

		_gridElement = gridElement;
	}
}
