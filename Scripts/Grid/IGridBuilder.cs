using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGridBuilder {

	GridElement[,] BuildGrid(int width, int length);
	void SetBattleGrid(BattleGrid battleGrid);
}
