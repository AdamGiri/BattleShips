﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventory {

	void SetPlayer(Player inventoryOwner);
	IListObject GetActiveListItem();

}
