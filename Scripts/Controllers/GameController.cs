using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController instance = null;
	

	
	
	void Awake () {

		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);


	}

	private void Start()
	{

		//create players  then create grids, assigning each player to its own grid
		GridController.instance.CreateGrids(PlayerController.instance.CreatePlayers());
		
	}


	void Update () {
		
	}
	
}
