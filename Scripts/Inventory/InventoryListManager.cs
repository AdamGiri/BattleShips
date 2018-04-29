using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryListManager : MonoBehaviour {

	[SerializeField]
	private GameObject _inventoryListItemTemplate;

	public static InventoryListManager instance = null;
	

	void Awake()
	{

		if (instance == null)
			instance = this;
		else
			Destroy(gameObject);
	}

	//creating inventory list composed of all the boats for the player
	public void GenerateInventory(Boat boat, BoatInventory boatInventory)
	{
		if (boat == null)
			throw new ArgumentNullException("boat is null");

		if (_inventoryListItemTemplate == null)
			throw new NullReferenceException("List item template is null");



		GameObject inventoryItem = Instantiate(_inventoryListItemTemplate) as GameObject;
		inventoryItem.SetActive(true);

		ListItem listItem = inventoryItem.GetComponent<ListItem>();

		listItem.SetName(boat.Name);
		listItem.SetHealth(boat.Health.ToString());
		//inventoryItem.GetComponent<ListItem>().SetName(boat.Missile.Damage);
		listItem.SetBoat(boat);
		listItem.SetInventory(boatInventory);

		listItem.transform.SetParent(transform.GetChild(0).GetChild(0).transform,false);
		Debug.Log("generating inventory");
	}

}
