using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoatInventory : IInventory {

	public Player Player { get; private set; }
	public Boat[] Boats { get; private set; }
	public IListObject ActiveListObject { get; set; }


	public BoatInventory()
	{
		Boats = new Boat[] { new PatrolBoat(100, "Patrol Boat", new Vector2(0,2)) };
	}

	public void SetPlayer(Player inventoryOwner)
	{
		
		if (inventoryOwner == null)
			throw new ArgumentNullException("Player is null");

		Debug.Log("setting player");
		Player = inventoryOwner;

		if (!Player.PlayerName.Equals("AI"))
			UpdateUI();
	}

	public void UpdateUI()
	{
		Debug.Log("updating ui");
		foreach (Boat boat in Boats)
		{
			InventoryListManager.instance.GenerateInventory(boat, this);
		}
	}

	// bug here.. not sure why this is throwing null when it has been set in ListItem OnClick()
	public IListObject GetActiveListItem()
	{
		if (ActiveListObject == null)
			throw new NullReferenceException("active list object is null");

		return ActiveListObject;
	}
}
