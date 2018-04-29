using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	public bool ActivePlayer { get; set; }
	public string PlayerName { get; private set; }
	public PlayerPosition PlayerSide { get; private set; }
	public IInventory Inventory { get; private set; }


	public enum PlayerPosition
	{
		LEFT,
		RIGHT
	}

	public Player(string playerName, PlayerPosition playerSide,  IInventory inventory)
	{
		PlayerName = playerName;
		PlayerSide = playerSide;
		Inventory = inventory;
		SetPlayerInventory();
	}


	private void SetPlayerInventory()
	{
		Inventory.SetPlayer(this);

	}
}
