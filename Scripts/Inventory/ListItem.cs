using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class ListItem : MonoBehaviour {

	[SerializeField]
	private Text _name;
	[SerializeField]
	private Text _health;
	[SerializeField]
	private Text _damage;


	public BoatInventory BoatInventory { get; private set; }
	public Boat Boat { get;  set; }

	public void SetName(string name)
	{
		_name.text = name;
	}

	public void SetHealth(string health)
	{
		_health.text = "HP: " + health;
	}

	public void SetDamage(string damage)
	{
		_damage.text = "Damage: " + damage;
	}

	public void SetBoat(Boat boat)
	{
		if (boat == null)
			throw new ArgumentNullException("boat is null");

		Debug.Log("setting boat");
		Boat = Boat;
	}

	public void SetInventory(BoatInventory boatInventory)
	{
		if (boatInventory == null)
			throw new ArgumentNullException("boatInventory is null");

		BoatInventory = boatInventory;
	}

	public void OnClick()
	{
		Debug.Log("clicked");


		BoatInventory.ActiveListObject = Boat;
		if (Boat == null)
			Debug.Log("Boat==null");
	}
}
