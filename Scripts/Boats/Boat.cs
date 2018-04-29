using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : IDamagable, IBuildable, IListObject
{

	public int Health { get; private set; }
	public string Name { get; private set; }
	public Vector2 Dimensions { get; private set; }

	public Boat(int health, string name, Vector2 dimensions)
	{
		Health = health;
		Name = name;
		Dimensions = dimensions;
	}



	public void InstantiateObject(Vector3 position, GameObject parent)
	{
		
	}

	public void TakeDamage(int damage)
	{
		
	}

	public IListObject GetListObject()
	{
		return this;
	}
}
