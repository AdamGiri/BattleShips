using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController instance = null;
	private Player[] players;

	void Awake()
	{

		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

	public Player[] CreatePlayers()
	{
		players = new Player[2];
		players[0] = new HumanPlayer("Player1", Player.PlayerPosition.LEFT, new BoatInventory());
		players[1] = new AIPlayer("AI", Player.PlayerPosition.RIGHT, new BoatInventory());
		return players;
	}
}
