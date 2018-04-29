using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StandardBattleGrid : BattleGrid
{
	public StandardBattleGrid(int width, int length, Player gridOwner
		, IGridBuilder gridBuilder) : base(width, length, gridOwner, gridBuilder)
	{
	}

	//grid specific to boats 
	public override void CalculateObjectSpaceAvailability(Vector2 arrayPosition)
	{
		Boat boat = (Boat)GridOwner.Inventory.GetActiveListItem();
		Debug.Log("boat dimensions " + boat.Dimensions);
	}
}
